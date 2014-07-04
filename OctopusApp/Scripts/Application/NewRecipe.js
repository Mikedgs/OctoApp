var NewRecipe = (function() {
    var listOfComponents = [];
    var listOfComponentsNode = $(".final-list");

    var removeComponent = function() {
        Component.error.text("");
        var id = $(this).parent().find(".id").text();
        var name = $(this).parent().find(".name").text();
        $(this).parent().remove();
        $("#" + id).remove();
        var index = NewRecipe.listOfComponents.indexOf(name);
        if (index > -1) {
            NewRecipe.listOfComponents.splice(index, 1);
        }
    }

    return {
        listOfComponents: listOfComponents,
        removeComponent: removeComponent,
        listOfComponentsNode: listOfComponentsNode
    };
})();