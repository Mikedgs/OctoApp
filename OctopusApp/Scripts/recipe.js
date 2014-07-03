$(document).ready(function() {
    $('.add-recipe').on('click', function (e) {
        e.preventDefault();
        var id = $(this).attr('data-id');
        console.log($("#"+id));
        $("#" + id).show();
    });

    $('.add-to-project').on('click', function(e) {
        e.preventDefault();
        $('.final-list').append("<li>" + $(this).parent().find("span").html() + "</li>");
        console.log($(this).parent().find(".id").text());
        $('form').append("<input type='hidden' name='ListOfIds' value='" + $(this).parent().find(".id").text() + "'>");
    });
});