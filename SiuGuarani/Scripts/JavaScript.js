$(Document).ready(function () {
    // Get the modal

    var modal = document.getElementById('modalAlumno');
    var modal2 = document.getElementById('modalDocente');
    var modal3 = document.getElementById('modalAdmin');

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
    window.onclick = function (event) {
        if (event.target == modal2) {
            modal2.style.display = "none";
        }
    }
    window.onclick = function (event) {
        if (event.target == modal3) {
            modal3.style.display = "none";
        }
    }

 
});