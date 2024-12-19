using System;

namespace DOTNET_MVC_DUC_SHOP1c.Redis
{
    public interface IRedisCacheService
    {
        T GetData<T>(string key);
        bool SetData<T>(string key, T value, DateTimeOffset expirationTime);
        object RemoveData(string key);
    }
}
