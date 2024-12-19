$(document).ready(function () {
    GetList();
});

$("#btnAdd").click(function () {
    $("#AddUpdateModal").modal("show");
    document.getElementById("ModalTitle").innerHTML = "Add";
    document.getElementById("Id").value = 0;
    document.getElementById("Id_div").style.display = "none";
    document.getElementById("Name").value = "";
});
async function Save() {
    var modelCategory = {
        Id: document.getElementById("Id").value,
        Name: document.getElementById("Name").value
    };
    await fetch("/Category/AddUpdate", {
        method: "POST",
        headers: { "Content-Type": "application/json; charset=utf-8" },
        body: JSON.stringify(modelCategory)
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

// Get List of Categories
function GetList() {
    $.ajax({
        url: "/Category/GetList",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (res) {
            console.log(res);
            for (var i = 0; i < res.length; i++) {
                //add data to the table
                $("#tbodyCategory").append(  
                    `<tr>
                           <td>
                               ${res[i].id} 
                            </td>
                            <td>
                               ${res[i].name} 
                            </td>
                            <td>
                                <a asp-controller="Category" onclick="Edit(${res[i].id})" class="btn btn-primary"> 
                                   <i class="fa-solid fa-pen-to-square"></i> Edit
                                </a> 
                                <a onclick="return confirm('Do you really want to delete this? ')" href="/Category/Delete?id=${res[i].id}" asp-route-id="${res[i].id}" class="btn btn-danger">
                                   <i class="fa-solid fa-trash"></i> Delete
                                </a>
                   
                             </td>
                         </tr>`);
                /*If I type asp-controller="Category" asp-action="Delete" asp-route-id="${res[i].id}"
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
        url: `/Category/GetById?id=${id}`,
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (res) {
            console.log(res);
            document.getElementById("Name").value = res.name;
        }
    });

}