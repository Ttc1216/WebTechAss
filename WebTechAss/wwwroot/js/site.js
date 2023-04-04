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
            spaceBetween: 40
        },

        1200: {
            slidesPerView: 3,
        }
    }
});
