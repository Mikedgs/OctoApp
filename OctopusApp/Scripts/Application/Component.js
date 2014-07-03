var Component = (function () {
    var addToRecipeButton = $('.add-to-recipe');

    var addComponentToNewRecipe = function() {
        event.preventDefault();
        NewRecipeView.resetErrors();
        var name = $(this).parent().find(".name").text();
        if (NewRecipe.checkIfNotDuplicate(name)) {
            NewRecipe.listOfComponents.push(name);
            NewRecipeView.addItemToRecipe($(this).parent().find("span").html(), $(this).parent().find(".id").text());
        } else {
            NewRecipeView.duplicateError(this);
        }
    };

    return {
        addToRecipeButton: addToRecipeButton,
        addComponentToNewRecipe: addComponentToNewRecipe
    };
})();