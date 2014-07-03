$(document).ready(function() {
    $('.add-recipe').on('click', function (e) {
        e.preventDefault();
        var id = $(this).attr('data-id');
        $("#" + id).show();
    });

    $('.add-to-project').on('click', function(e) {
        e.preventDefault();
        $(".duplicate-error").text("");
        var name = $(this).parent().find(".name").text();
        if (NewRecipe.listOfComponents.indexOf(name) < 0) {
            NewRecipe.listOfComponents.push(name);
            $('.final-list').append("<li>" + $(this).parent().find("span").html() + "<a href='#' class='delete'>X</span></li>");
            console.log($(this).parent().find(".id").text());
            $('form').append("<input type='hidden' name='ListOfIds' id='" + $(this).parent().find(".id").text() + "' value='" + $(this).parent().find(".id").text() + "'>");
        } else {
            $(this).parent().find(".duplicate-error").text("Component already in recipe");
        }
        
    });

    $('.final-list').on('click', '.delete', function () {
        $(".duplicate-error").text("");
        var id = $(this).parent().find(".id").text();
        var name = $(this).parent().find(".name").text();
        $(this).parent().remove();
        $("#" + id).remove();
        var index = NewRecipe.listOfComponents.indexOf(name);
        if (index > -1) {
            NewRecipe.listOfComponents.splice(index, 1);
        }
    });
});