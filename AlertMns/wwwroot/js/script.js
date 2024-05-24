document.addEventListener('DOMContentLoaded', (event) => {
    document.querySelectorAll('.rotatable').forEach(function (element) {
        element.addEventListener('click', function () {
            this.querySelector('.img-arrow-white').classList.toggle('rotated');
        });
    });

    window.addEventListener('resize', function () {
        var navbar = document.querySelector('.navbar');
        if (window.innerWidth > 1024) {
            navbar.style.left = "0px";
        } else {
            navbar.style.left = "-576px";
        }
    });

    document.querySelector('.button-burger').addEventListener('click', function () {
        var navbar = document.querySelector('.navbar');
        if (navbar.style.left === "-576px") {
            navbar.style.left = "0px";
        } else {
            navbar.style.left = "-576px";
        }
    });

    document.querySelector('.button-close').addEventListener('click', function () {
        var navbar = document.querySelector('.navbar');
        if (navbar.style.left === "0px") {
            navbar.style.left = "-576px";
        } else {
            navbar.style.left = "0px";
        }
    });

    document.querySelectorAll('h1').forEach(function (h1) {
        let text = h1.textContent;
        h1.textContent = text.charAt(0).toUpperCase() + text.slice(1).toLowerCase();
    });
});