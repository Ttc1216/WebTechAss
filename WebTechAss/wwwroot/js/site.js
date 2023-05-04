// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//const wrapper = document.querySelector('.wrapper');
//const loginLink = document.querySelector('.login-link');
//const registerLink = document.querySelector('.register-link');
//const btnPopup = document.querySelector('.btnlogin-popup');
//const iconClose = document.querySelector('.icon-close');

//registerLink.addEventListener('click', () => { wrapper.classList.add('active'); });
//loginLink.addEventListener('click', () => { wrapper.classList.remove('active'); });
//btnPopup.addEventListener('click', () => { wrapper.classList.add('active-popup'); });
//iconClose.addEventListener('click', () => { wrapper.classList.remove('active-popup'); });
const items = document.querySelectorAll('.accordion button');
function toggleAccordion() {
    const itemToggle = this.getAttribute('aria-expanded');
    for (i = 0; i < items.length; i++) {
        items[i].setAttribute('aria-expanded', 'false');
    }
    if (itemToggle == 'false') {
        this.setAttribute('aria-expanded', 'true');
    }
}
items.forEach((item) => item.addEventListener('click', toggleAccordion));

/**
 * Testimonials slider
 */
new Swiper('.testimonials-slider', {
    speed: 600,
    loop: true,
    autoplay: {
        delay: 5000,
        disableOnInteraction: false
    },
    slidesPerView: 'auto',
    pagination: {
        el: '.swiper-pagination',
        type: 'bullets',
        clickable: true
    },
    breakpoints: {
        320: {
            slidesPerView: 1,
            spaceBetween: 20
        },

        1200: {
            slidesPerView: 3,
            spaceBetween: 20
        }
    }
});

/**
 * Animation on scroll
 */
window.addEventListener('load', () => {
    AOS.init({
        duration: 1000,
        easing: 'ease-in-out',
        once: true,
        mirror: false
    })
});
/*Popup*/
function togglePopup() {
    document.getElementById("popup-1").classList.toggle("active");
    document.getElementById("popup-2").classList.toggle("active");
}

//function togglePopup(num) {
//    popups[num].classList.toggle("active");
//}

//let popups = document.getElementsByClassName("popup");
//let closeBtns = document.getElementsByClassName("close-btn");
//let openBtns = document.getElementsByClassName("btn");

//for (let i = 0; i < closeBtns.length; i++) {
//    closeBtns[i].addEventListener("click", function () { togglePopup(i) });
//    openBtns[i].addEventListener("click", function () { togglePopup(i) });
//}