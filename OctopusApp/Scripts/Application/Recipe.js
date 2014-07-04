var Recipe = (function () {
    var addRecipeButton = $('.add-recipe');

    var displayRecipe = function() {
        event.preventDefault();
        var id = $(this).attr('data-id');
        $("#" + id).show();
    };

    return {
        addRecipeButton: addRecipeButton,
        displayRecipe: displayRecipe
    };
})();