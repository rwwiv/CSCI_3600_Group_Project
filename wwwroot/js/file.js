/*
function getFileUrl(html) {
    var user = html.find('.owner').text();
    var file = $.trim(html.find('.filename').text());
    console.log(user);
    console.log(file);
    return (user+ "\\" + file)
}

$('.file').on("click", function (event) {
    event.preventDefault();

    console.log(getFileUrl($(this)));
    var fileUrl = getFileUrl($(this));
    console.log("Here");
    //window.location.href = "https://localhost:5001/userfiles/word1.docx";

    var req = new XMLHttpRequest();
    req.open("GET", "https://localhost:5001/api/Files/", true);
    req.responseType = "blob";
    console.log(req);
    req.onload = function (event) {
        var blob = req.response;
        console.log(blob.size);
        var link = document.createElement('a');
        link.href = window.URL.createObjectURL(blob);
        link.download = "Dossier_" + new Date() + ".txt";
        link.click();
    };
  
    $.ajax({
        type: "GET",
        url: "https://localhost:5001/Home/Download/?fileDir=" + fileUrl,
        success: function (response) {
            console.log(response);
            window.location = response;
        },
        error: function () {
            alert("Delete didn't work");
        }
    });
});

$('.delete').on("click", function (event) {
    event.preventDefault();
    $.ajax({
        type: "GET",
        url: "/Delete/?fileDir=" + fileUrl,
        success: function () {
            alert("delete worked");
        },
        error: function () {
            alert("Delete didn't work");
        }
    });
    event.stopPropagation();
});
*/

$(function() {
    $(".clickable-file")
        .click(function(e) {
            window.location = $(this).data("href");
        })
        .hover(
            function() {
                $(this).css({
                    'color': 'gray',
                    'cursor': 'pointer'
                });
            },
            function() {
                $(this).removeAttr('style');
            });
    $('.delete').click(function(e) {
        e.stopPropagation();
    });
    $('.file-card-info').click(function(e) {
        e.stopPropagation();
    });
    $('.view').click(function(e) {
        e.stopPropagation();
    });
});

function deleteLoad(fileloc) {
    $.ajax({
        type: "GET",
        url: "/Home/Delete/?fileDir=" + fileloc,
        success: function (response) {
            console.log(response);
            location.reload();
        },
        error: function () {
            console.log("Delete didn't work");
        }
    });
}

function viewLoad(fileloc) {
    console.log(fileloc);
    $.ajax({
        type: "GET",
        url: "/Home/View/?fileName=" + fileloc,
        success: function (response) {
            console.log(response);
            var myWindow = window.open("", "MsgWindow", "width=1200,height=1000");
            myWindow.document.write(response);
        },
        error: function () {
            alert("No file exists");
        }
    });
}
