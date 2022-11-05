function get_image() {
    var selected = document.getElementById('surfaceSelect').options[document.getElementById('surfaceSelect').selectedIndex].value;
    document.surfacePreview.style.visibility = "visible";
    document.surfacePreview.src = "../Images/surface/" + selected + ".jpg";
}