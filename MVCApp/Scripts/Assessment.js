$(document).ready(function () {
});

function DeleteAssessment()
{
    alert("calling DeleteAssessment");

    var input = {
        "id" : 9,
        "firstname" :"Adam",
        "lastname" :"cooper"
    };

    $.ajax({
        url: "/api/assessment/DeleteAssessment",
        type: "DELETE",
        data: JSON.stringify(input),
        contentType: "application/json",
        cache: false,
        success: function (result) {
            alert("Deleted successfully!!");
        },
        error: function (result) {
            alert("Delete Failed!!");
        }
    });
}

function GetAssessment() {
    alert("calling GetAssessment");


    $.ajax({
        url: "/api/assessment/AssessmentDetail",
        type: "GET",
        //data: JSON.stringify(input),
        contentType: "application/json",
        cache: false,
        success: function (result) {
            alert(JSON.stringify(result.responseText));
        },
        error: function (result) {
            alert(JSON.stringify(result.responseText));
        }
    });
}