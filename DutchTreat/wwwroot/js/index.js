$(document).ready(function () {
    var x = 0;
    var s = "";

    console.log("Hello Pluralsight");


    // JQuery

    //var theForm = document.getElementById("theForm");
    //theForm.hidden = true;

    var theForm = $("#theForm");
    theForm.hide();

    //var button = document.getElementById("buyButton");
    //button.addEventListener("click", function () {
    //    alert("Buying item");
    //})

    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying item");
    })


    //var productinfo = document.getElementsByClassName("product-props");
    //var listitems = productinfo.item[0].children;

    var productinfo = $(".product-props li");
    productinfo.on("click", function () {
        console.log("you clicked on " + $(this).text());
    }
    );

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    })


});
