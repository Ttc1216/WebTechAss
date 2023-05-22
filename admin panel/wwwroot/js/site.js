//// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
//// for details on configuring this project to bundle and minify static web assets.

//// Write your JavaScript code.
const body = document.querySelector("body");
const    modeToggle = body.querySelector(".mode-toggle");
const    sidebar = body.querySelector("nav");
const    sidebarToggle = body.querySelector(".sidebar-toggle");

let getMode = localStorage.getItem("mode");
if (getMode && getMode === "dark") {
    body.classList.toggle("dark");
}

let getStatus = localStorage.getItem("status");
if (getStatus && getStatus === "close") {
    sidebar.classList.toggle("close");
}

  modeToggle.addEventListener("click", () => {
    body.classList.toggle("dark");
      if (body.classList.contains("dark")) {
          localStorage.setItem("mode", "dark");
      } else {
          localStorage.setItem("mode", "light");
      }
});

sidebarToggle.addEventListener("click", () => {
    sidebar.classList.toggle("close");
    if (sidebar.classList.contains("close")) {
        localStorage.setItem("status", "close");
    }else{
        localStorage.setItem("status", "open");
    }
})

document.addEventListener(
    "click",
    function (event) {
        var target = event.target;
        var replyForm;
        if (target.matches("[data-toggle='reply-form']")) {
            replyForm = document.getElementById(target.getAttribute("data-target"));
            replyForm.classList.toggle("d-none");
        }
    },
    false
);


const form = document.querySelector('#inviteForm');
const input = document.querySelector('input');
const main = document.querySelector('.main');
const ul = document.querySelector('#invitedList');

/*
1. create li
------------
*/
function createLi() {
    const li = document.createElement('li');
    const span = document.createElement('span');
    span.textContent = input.value;
    const label = document.createElement('label');
    label.textContent = 'confirmed';
    const checkbox = document.createElement('input');
    checkbox.type = 'checkbox';
    const editBtn = document.createElement('button');
    editBtn.textContent = 'edit';
    const removeBtn = document.createElement('button');
    removeBtn.textContent = 'remove';

    li.appendChild(span);
    li.appendChild(label);
    label.appendChild(checkbox);
    li.appendChild(editBtn);
    li.appendChild(removeBtn);

    return li;
}

form.addEventListener('submit', (event) => {
    event.preventDefault();

    const li = createLi();

    if (input.value === '') {
        alert('Enter the name please!!!');
    } else {
        ul.appendChild(li);
    }
});

/*
2. Add responded class
----------------------
*/
ul.addEventListener('change', (event) => {
    const checkbox = event.target;
    const checked = checkbox.checked;
    const li = checkbox.parentNode.parentNode;
    if (checked) {
        li.className = 'responded';
    } else {
        li.className = '';
    }
});

/*
3. Button actions
-----------------
*/
ul.addEventListener('click', (event) => {
    if (event.target.tagName === 'BUTTON') {
        const button = event.target;
        const li = button.parentNode;
        const ul = li.parentNode;
        if (button.textContent === 'remove') {
            ul.removeChild(li);
        } else if (button.textContent === 'edit') {
            const span = li.firstElementChild;
            const input = document.createElement('input');
            input.type = 'text';
            input.value = span.textContent;
            li.insertBefore(input, span);
            li.removeChild(span);
            button.textContent = 'save';
        } else if (button.textContent === 'save') {
            const input = li.firstElementChild;
            const span = document.createElement('span');
            span.textContent = input.value;
            li.insertBefore(span, input);
            li.removeChild(input);
            button.textContent = 'edit';
        }
    }
});

/*
4. create and append elements
-----------------------------
*/
const div = document.createElement('div');
div.className = 'showHide';
const filterLabel = document.createElement('label');
filterLabel.textContent = 'Hide those who have not responded';
const filterCheckbox = document.createElement('input');
filterCheckbox.type = 'checkbox';

div.appendChild(filterLabel);
filterLabel.appendChild(filterCheckbox);
main.insertBefore(div, ul);

filterCheckbox.addEventListener('change', (event) => {
    const isChecked = event.target.checked;
    const lis = ul.children;

    if (isChecked) {
        for (let i = 0; i < lis.length; i++) {
            var li = lis[i];

            if (li.className === 'responded') {
                li.style.display = '';
            } else {
                li.style.display = 'none';
            }
        }
    } else {
        for (let i = 0; i < lis.length; i++) {
            var li = lis[i];
            li.style.display = '';
        }
    }
});



/*Calendar*/
//const calendar = document.querySelector(".calendar"),
//    date = document.querySelector(".date"),
//    daysContainer = document.querySelector(".days"),
//    prev = document.querySelector(".prev"),
//    next = document.querySelector(".next");

//let today = new Date();
//let activeDay;
//let month = today.getMonth();
//let year = today.getFullYear();

//const months = [
//    "January",
//    "February",
//    "march",
//    "April",
//    "June",
//    "July",
//    "August",
//    "September",
//    "October",
//    "November",
//    "Decembetr",
//];


//function initCalendar() {
//    const firstDay = new Date(year, month, 1);
//    const lastDay = new Date(year, month + 1, 0);
//    const prevLastDay = new Date(year, month, 0);
//    const prevDays = prevLastDay.getDate();
//    const lastDate = lastDay.getDate();
//    const day = firstDay.getDate();
//    const nextDays = 7 - lastDay.getDay() - 1;

//    date.innerHTML = months[month] + " " + year;


//    let days = "";

//    for (let x = day; x > 0; x--) {
//        days += `<div class="day prev-date">${prevDays - x + 1}</div>`;
//    }


//    for (let i = 1; i <= lastDate; i++) {

//        if (
//            i === new Date().getDate() &&
//            year === new Date().getFullYear() &&
//            month === new Date().getMonth()
//        ) {
//            days += `<div class="day today">${i}</div>`;
//        }
//        else {
//            days += `<div class="day ">${i}</div>`;
//        }
//    }
//    for (let j = 1; j <= nextDays; j++) {
//        days += `<div class="day next-date">${j}</div>`;
//    }
//   daysContainer.innerHTML = days;
//}

//initCalendar();