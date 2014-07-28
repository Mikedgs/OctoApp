var Accordions = (function() {
    var init = function() {
        $("#home-accordion").accordion({
            heightStyle: "content",
            collapsible: true,
            active: false
        });

        $(".recipe-accordion").accordion({
            heightStyle: "content",
            collapsible: true,
            active: false
        });
    };

    return {
        init: init
    };
})();