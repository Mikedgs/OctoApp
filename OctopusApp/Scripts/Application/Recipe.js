var Recipe = (function() {
    var displayRecipe = function() {
        event.preventDefault();
        var id = $(this).attr('data-id');
        $("#" + id).show();
    };

    return {
        displayRecipe: displayRecipe
    };
})();