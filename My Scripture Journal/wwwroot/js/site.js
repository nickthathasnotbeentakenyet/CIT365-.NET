// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var canva = document.getElementById("canva");
var ctx = canva.getContext("2d");

canva.height = window.innerHeight;
canva.width = window.innerWidth;
var matrix = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789#$%^&*()*&^%";
matrix = matrix.split("");

var font_size = 10;
var columns = canva.width / font_size;
var drops = [];
for (var x = 0; x < columns; x++)
    drops[x] = 1;

function draw() {
    ctx.fillStyle = "rgba(0, 0, 0, 0.04)";
    ctx.fillRect(0, 0, canva.width, canva.height);

    ctx.fillStyle = "#50c878"; //green text
    ctx.font = font_size + "px arial";
    for (var i = 0; i < drops.length; i++) {
        var text = matrix[Math.floor(Math.random() * matrix.length)];
        ctx.fillText(text, i * font_size, drops[i] * font_size);
        if (drops[i] * font_size > canva.height && Math.random() > 0.975)
            drops[i] = 0;
        drops[i]++;
    }
}
setInterval(draw, 75);