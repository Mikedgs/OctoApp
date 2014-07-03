var Component = (function () {
    var error = $(".duplicate-error");
    var duplicateErrorMessage = "Component already in recipe";

    var addComponentToNewRecipe = function() {
        event.preventDefault();
        error.text("");
        var name = $(this).parent().find(".name").text();
        if (NewRecipe.listOfComponents.indexOf(name) < 0) {
            NewRecipe.listOfComponents.push(name);
            NewRecipe.listOfComponentsNode.append("<li>" + $(this).parent().find("span").html() + "<a href='#' class='delete'>X</span></li>");
            $('form').append("<input type='hidden' name='ListOfIds' id='" + $(this).parent().find(".id").text() + "' value='" + $(this).parent().find(".id").text() + "'>");
        } else {
            $(this).parent().find(error).text(duplicateErrorMessage);
        }
    }

    return {
        addComponentToNewRecipe: addComponentToNewRecipe
    };
})();