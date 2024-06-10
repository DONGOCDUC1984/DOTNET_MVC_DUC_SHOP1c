$(document).ready(function () {
    GetList();
    GetProvinceCityList();
});

$("#btnAdd").click(function () {
    $("#AddUpdateModal").modal("show");
    document.getElementById("ModalTitle").innerHTML = "Add";
    document.getElementById("Id").value = 0;
    document.getElementById("Id_div").style.display = "none";
    document.getElementById("Name").value = "";
});
async function Save() {
    var modelDistrict = {
        Id: document.getElementById("Id").value,
        Name: document.getElementById("Name").value,
        ProvinceCityId: $('#ProvinceCityId').val()
    };
    console.log("modelDistrict: " + JSON.stringify(modelDistrict));
    await fetch("/District/AddUpdate", {
        method: "POST",
        headers: { "Content-Type": "application/json; charset=utf-8" },
        body: JSON.stringify(modelDistrict)
    })
        .then(res => {
            console.log(res);
            //return response.ok ? response.json() : Promise.reject(response);
        });
    GetList();
    $("#AddUpdateModal").modal("hide");
}
$("#btnSave").click(function () {
    Save();
});

// Get List of Districts
function GetList() {
    $.ajax({
        url: "/District/GetList",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (res) {
            console.log(res);
            for (var i = 0; i < res.length; i++) {
                //add data to the table
                $("#tbodyDistrict").append(
                    `<tr>
                           <td>
                               ${res[i].id} 
                            </td>
                            <td>
                               ${res[i].name} 
                            </td>
                            <td>
                               ${res[i].provinceCityName} 
                            </td>
                            <td>
                                <a asp-controller="District" onclick="Edit(${res[i].id})" class="btn btn-primary"> 
                                   <i class="fa-solid fa-pen-to-square"></i> Edit
                                </a> 
                                <a onclick="return confirm('Do you really want to delete this? ')" href="/District/Delete?id=${res[i].id}" asp-route-id="${res[i].id}" class="btn btn-danger">
                                   <i class="fa-solid fa-trash"></i> Delete
                                </a>
                   
                             </td>
                         </tr>`);
                /*If I type asp-controller="District" asp-action="Delete" asp-route-id="${res[i].id}"
                   in the above delete button,it will not work   */
            }
        }
    })
}

function Edit(id) {
    $("#AddUpdateModal").modal("show");
    document.getElementById("ModalTitle").innerHTML = "Update";
    document.getElementById("Id").value = id;
    document.getElementById("Id_div").style.display = "block";

    $.ajax({
        url: `/District/GetById?id=${id}`,
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (res) {
            console.log(res);
            document.getElementById("Name").value = res.name;
            $('#ProvinceCityId').val(res.provinceCityId)  ;
        }
    });

}

function GetProvinceCityList() {
    $.ajax({
        url: '/District/GetProvinceCityList',
        type: 'GET',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            $('#ProvinceCityId').find('option').remove();
            console.log(data);

            for (var i = 0; i < data.length; i++) {
                $('#ProvinceCityId').append(`<option value= ${data[i].id} > ${data[i].name}   </option>`)
            }
        }
    })
}
