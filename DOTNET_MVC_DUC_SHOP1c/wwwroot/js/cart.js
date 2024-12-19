
async function Save() {
    var UserTel = document.getElementById("UserTel").value;
    var UserAddress = document.getElementById("UserAddress").value;
    
    try {
            var res = await fetch(`/Cart/AddOrder?UserTel=${UserTel}&UserAddress=${UserAddress}`);
        }
    catch (err) {
               console.log(err);
        }    
}

$("#btnOrder").click(function () {
    Save();
});

