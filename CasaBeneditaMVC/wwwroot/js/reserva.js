document.getElementById("btn-proximo").addEventListener("click", function () {
    document.querySelectorAll(".input-row").forEach(e => {
        e.classList.remove("disabled");
    });
});