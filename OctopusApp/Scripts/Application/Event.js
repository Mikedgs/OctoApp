var Event = (function() {
    var bindClickEvents = function() {
        Recipe.addRecipeButton.on('click', Recipe.displayRecipe);
        Component.addToRecipeButton.on('click', Component.addComponentToNewRecipe);
        NewRecipe.listOfComponentsNode.on('click', '.delete', NewRecipe.removeComponent);
    };

    return {
        bindClickEvents: bindClickEvents
    };
})();