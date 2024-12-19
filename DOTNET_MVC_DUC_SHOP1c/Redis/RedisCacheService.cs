using Newtonsoft.Json;
using StackExchange.Redis;
using System;

namespace DOTNET_MVC_DUC_SHOP1c.Redis
{
    public class RedisCacheService : IRedisCacheService
    {
        private IDatabase _db;
        public RedisCacheService()
        {
            ConfigureRedis();
        }
        private void ConfigureRedis()
        {
            var redis = ConnectionMultiplexer.Connect("localhost:6379");
            _db = redis.GetDatabase();
        }
        public T GetData<T>(string key)
        {
            var value = _db.StringGet(key);
            if (!string.IsNullOrEmpty(value))
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            return default;
        }
        public bool SetData<T>(string key, T value, DateTimeOffset expirationTime)
        {
            TimeSpan expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
            //var isSet = _db.StringSet(key, JsonConvert.SerializeObject(value), expiryTime);
            //If I replace the following by the above line, there will be an error.
            var isSet = _db.StringSet(key, JsonConvert.SerializeObject(value, Formatting.Indented,
                            new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                            }
                            ), expiryTime);
            return isSet;
        }
        public object RemoveData(string key)
        {
            bool _isKeyExist = _db.KeyExists(key);
            if (_isKeyExist == true)
            {
                return _db.KeyDelete(key);
            }
            return false;
        }

    }
}
