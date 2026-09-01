/* =========================================================
   SHRUTI SHAH PORTFOLIO
   Main JavaScript
   ========================================================= */


/* =========================
   ELEMENTS
   ========================= */

const header = document.getElementById("header");

const menuToggle = document.getElementById("menu-toggle");

const navMenu = document.getElementById("nav-menu");

const navLinks = document.querySelectorAll(".nav-link");

const sections = document.querySelectorAll("main section");

const backToTop = document.getElementById("back-to-top");

const year = document.getElementById("year");


/* =========================
   CURRENT YEAR
   ========================= */

if (year) {
    year.textContent = new Date().getFullYear();
}


/* =========================
   MOBILE MENU
   ========================= */

menuToggle.addEventListener("click", () => {

    const isOpen = navMenu.classList.toggle("open");

    menuToggle.setAttribute(
        "aria-expanded",
        isOpen
    );

});


/* =========================
   CLOSE MOBILE MENU
   ========================= */

navLinks.forEach((link) => {

    link.addEventListener("click", () => {

        navMenu.classList.remove("open");

        menuToggle.setAttribute(
            "aria-expanded",
            "false"
        );

    });

});


/* =========================
   HEADER ON SCROLL
   ========================= */

function updateHeader() {

    if (window.scrollY > 40) {

        header.classList.add("scrolled");

    } else {

        header.classList.remove("scrolled");

    }

}

window.addEventListener(
    "scroll",
    updateHeader,
    { passive: true }
);

updateHeader();


/* =========================
   ACTIVE NAVIGATION
   ========================= */

const observerOptions = {
    root: null,
    rootMargin: "-30% 0px -60% 0px",
    threshold: 0
};


const sectionObserver = new IntersectionObserver(
    (entries) => {

        entries.forEach((entry) => {

            if (entry.isIntersecting) {

                const currentSection = entry.target.id;

                navLinks.forEach((link) => {

                    link.classList.remove("active");

                    const linkTarget =
                        link.getAttribute("href");

                    if (linkTarget === `#${currentSection}`) {

                        link.classList.add("active");

                    }

                });

            }

        });

    },
    observerOptions
);


sections.forEach((section) => {

    sectionObserver.observe(section);

});


/* =========================
   SCROLL REVEAL
   ========================= */

const revealElements =
    document.querySelectorAll(".reveal");


const revealObserver =
    new IntersectionObserver(
        (entries, observer) => {

            entries.forEach((entry) => {

                if (entry.isIntersecting) {

                    entry.target.classList.add("visible");

                    observer.unobserve(entry.target);

                }

            });

        },
        {
            threshold: 0.12
        }
    );


revealElements.forEach((element) => {

    revealObserver.observe(element);

});


/* =========================
   BACK TO TOP
   ========================= */

function updateBackToTop() {

    if (window.scrollY > 700) {

        backToTop.classList.add("visible");

    } else {

        backToTop.classList.remove("visible");

    }

}

window.addEventListener(
    "scroll",
    updateBackToTop,
    { passive: true }
);


backToTop.addEventListener(
    "click",
    () => {

        window.scrollTo({
            top: 0,
            behavior: "smooth"
        });

    }
);


/* =========================
   KEYBOARD ACCESSIBILITY
   ========================= */

document.addEventListener("keydown", (event) => {

    if (
        event.key === "Escape" &&
        navMenu.classList.contains("open")
    ) {

        navMenu.classList.remove("open");

        menuToggle.setAttribute(
            "aria-expanded",
            "false"
        );

        menuToggle.focus();

    }

});


/* =========================
   IMAGE FALLBACK
   ========================= */

const projectImages =
    document.querySelectorAll(
        ".project-image img, .portrait-frame img"
    );


projectImages.forEach((image) => {

    image.addEventListener("error", () => {

        image.style.display = "none";

    });

});