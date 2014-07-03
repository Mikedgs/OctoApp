var NewRecipe = (function() {
    var listOfComponents = [];
    var listOfComponentsNode = $(".final-list");

    var checkIfNotDuplicate = function(name) {
        return (listOfComponents.indexOf(name) < 0);
    };
    var removeComponent = function() {
        NewRecipeView.resetErrors();
        NewRecipeView.removeComponent(this);
        removeFromList($(this).parent().find(".name").text());
    };
    var removeFromList = function(name) {
        var index = listOfComponents.indexOf(name);
        if (index > -1) {
            listOfComponents.splice(index, 1);
        };
    };
    return {
        listOfComponents: listOfComponents,
        removeComponent: removeComponent,
        listOfComponentsNode: listOfComponentsNode,
        checkIfNotDuplicate: checkIfNotDuplicate
    };
})();