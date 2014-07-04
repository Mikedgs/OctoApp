$(document).ready(function () {
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
    Event.bindClickEvents();
});