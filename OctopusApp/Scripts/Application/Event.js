var Event = (function() {
    var bindClickEvents = function() {
        $('.add-recipe').on('click', Recipe.displayRecipe);
        $('.add-to-project').on('click', Component.addComponentToNewRecipe);
        NewRecipe.listOfComponentsNode.on('click', '.delete', NewRecipe.removeComponent);
    };

    return {
        bindClickEvents: bindClickEvents
    };
})();