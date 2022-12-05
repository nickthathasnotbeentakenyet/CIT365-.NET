const btn = document.getElementById('bg');
const bg = [
    'url(../../1.jpg)', 'url(../../2.jpg)',
    'url(../../3.jpg)', 'url(../../4.jpg)',
    'url(../../5.jpg)', 'url(../../1.jpeg)',
    'url(../../2.jpeg)', , 'url(../../1.png)'
];
function change() {
    document.body.style.backgroundImage = bg[Math.floor(7 *
        Math.random())];
    document.body.style.backgroundSize = 'cover';
}
btn.addEventListener('click', change);
const btwbtn = document.getElementById('backtodefault');
function todefault() {
    document.body.style.backgroundImage = "url(../../main.jpg)"
    document.body.style.backgroundSize = 'cover';
}
btwbtn.addEventListener('click', todefault);