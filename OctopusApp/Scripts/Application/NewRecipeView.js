var NewRecipeView = (function() {
    var error = $(".duplicate-error");
    var listOfComponentsNode = $(".final-list");
    var submitForm = $('form');
    var duplicateErrorMessage = "Component already in recipe";

    var showRecipe = function(id) {
        $("#" + id).show();
    };

    var resetErrors = function() {
        error.text("");
    };

    var addItemToRecipe = function(component, id) {
        listOfComponentsNode.append("<li>" + component + "<span class='delete glyphicon glyphicon-remove'></span></li>");
        submitForm.append("<input type='hidden' name='ListOfIds' id='" + id + "' value='" + id + "'>");
    };

    var duplicateError = function(self) {
        $(self).parent().find(error).text(duplicateErrorMessage);
    };
    var removeComponent = function(self) {
        $(self).parent().remove();
        $("#" + $(self).parent().find(".id").text()).remove();
    };
    return {
        showRecipe: showRecipe,
        resetErrors: resetErrors,
        addItemToRecipe: addItemToRecipe,
        duplicateError: duplicateError,
        removeComponent: removeComponent
    };
})();