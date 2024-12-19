//If the page is loaded,GetDistrictByProvinceCityId () will be called
$(document).ready(function () {
    getDistrictByProvinceCityId();
});
// If #ProvinceCityId is changed ,GetDistrictByProvinceCityId () will be called
$("#ProvinceCityId").change(function () {
    getDistrictByProvinceCityId();
});

function getDistrictByProvinceCityId() {
    $.ajax({
        url: '/Home/GetDistrictByProvinceCityId',
        type: 'GET',
        data: {
            ProvinceCityId: $('#ProvinceCityId').val(),
        },
        success: function (data) {
            $('#DistrictId').find('option').remove();
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                $('#DistrictId').append(`<option value= ${data[i].id} > ${data[i].name}   </option>`)
            }
        }
    })
}

function Add(productId) {
    // Check if User is logged in
    if (document.getElementById("username") == null) {
        window.location.href = "/Identity/Account/Login";
    }
    $.ajax({
        url: '/Cart/AddCartItem',
        type: 'GET',
        data: {
            ProductId: productId,
        },
        success: function (data) {
            document.getElementById("CartLength").innerHTML = data;
            window.location.href = "#CartLength";
        }
    })
}

