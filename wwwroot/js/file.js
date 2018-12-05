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
        url: "Delete/?fileName=" + fileloc,
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
        url: "View/?fileName=" + fileloc,
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


