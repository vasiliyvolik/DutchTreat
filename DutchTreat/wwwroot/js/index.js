﻿var x = 0;
var s = "";

console.log("Hello Pluralsight");

var theForm = document.getElementById("theForm");
theForm.hidden = true;

var button = document.getElementById("buyButton");
button.addEventListener("click", function () {
    alert("Buying item");
})

var productinfo = document.getElementsByClassName("product-props");
var listitems = productinfo.item[0].children;
