var Recipe = (function () {
    var addRecipeButton = $('.add-recipe');

    var displayRecipe = function() {
        event.preventDefault();
        var id = $(this).attr('data-id');
        NewRecipeView.showRecipe(id);
    };

    return {
        addRecipeButton: addRecipeButton,
        displayRecipe: displayRecipe
    };
})();