/* =========================================================
   SHRUTI SHAH PORTFOLIO
   Main stylesheet
   ========================================================= */


/* =========================
   RESET
   ========================= */

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
}

body {
    font-family: "DM Sans", sans-serif;
    background: #f7f5f1;
    color: #1b1b1b;
    line-height: 1.6;
    overflow-x: hidden;
}

img {
    max-width: 100%;
    display: block;
}

a {
    color: inherit;
    text-decoration: none;
}

button {
    font: inherit;
}

ul {
    list-style: none;
}


/* =========================
   VARIABLES
   ========================= */

:root {

    --background: #f7f5f1;
    --surface: #eeebe5;
    --white: #ffffff;

    --text: #1b1b1b;
    --muted: #696660;

    --border: #d7d3cb;

    --accent: #7c2634;
    --accent-dark: #5e1c28;

    --max-width: 1240px;

    --section-padding: 120px;

    --transition: 0.3s ease;
}


/* =========================
   GLOBAL
   ========================= */

.container {
    width: min(90%, var(--max-width));
    margin-inline: auto;
}

.section {
    padding: var(--section-padding) 0;
}

.eyebrow {
    font-size: 0.72rem;
    font-weight: 700;
    letter-spacing: 0.18em;
    text-transform: uppercase;
    color: var(--accent);
    margin-bottom: 20px;
}

.section-heading {
    margin-bottom: 70px;
}

.section-heading h2 {
    max-width: 780px;
    font-family: "Playfair Display", serif;
    font-size: clamp(2.5rem, 5vw, 4.5rem);
    font-weight: 400;
    line-height: 1.08;
    letter-spacing: -0.04em;
}

.section-heading h2 em {
    color: var(--accent);
    font-style: italic;
}


/* =========================
   HEADER
   ========================= */

.header {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    z-index: 1000;

    background: rgba(247, 245, 241, 0.9);
    backdrop-filter: blur(15px);

    border-bottom: 1px solid transparent;

    transition: var(--transition);
}

.header.scrolled {
    border-bottom-color: var(--border);
}

.navbar {
    height: 78px;

    display: flex;
    align-items: center;
    justify-content: space-between;
}

.logo {
    font-family: "Playfair Display", serif;
    font-size: 1.8rem;
    font-weight: 600;
}

.logo span {
    color: var(--accent);
}

.nav-menu {
    display: flex;
    align-items: center;
    gap: 30px;
}

.nav-link {
    position: relative;

    font-size: 0.78rem;
    font-weight: 600;

    color: var(--muted);

    transition: var(--transition);
}

.nav-link::after {
    content: "";

    position: absolute;
    bottom: -7px;
    left: 0;

    width: 0;
    height: 1px;

    background: var(--accent);

    transition: var(--transition);
}

.nav-link:hover,
.nav-link.active {
    color: var(--text);
}

.nav-link.active::after,
.nav-link:hover::after {
    width: 100%;
}

.nav-resume {
    padding: 11px 18px;

    background: var(--text);
    color: var(--white);

    font-size: 0.75rem;
    font-weight: 600;

    transition: var(--transition);
}

.nav-resume:hover {
    background: var(--accent);
}

.menu-toggle {
    display: none;

    border: 0;
    background: transparent;

    cursor: pointer;
}

.menu-toggle span {
    display: block;

    width: 25px;
    height: 2px;

    margin: 5px;

    background: var(--text);

    transition: var(--transition);
}


/* =========================
   HERO
   ========================= */

.hero {
    min-height: 100vh;

    display: flex;
    align-items: center;

    padding-top: 150px;
}

.hero-grid {
    display: grid;

    grid-template-columns: 1.05fr 0.95fr;

    gap: 80px;

    align-items: center;
}

.hero-content h1 {
    max-width: 760px;

    font-family: "Playfair Display", serif;

    font-size: clamp(3.3rem, 6.5vw, 6.8rem);

    font-weight: 400;

    line-height: 0.98;

    letter-spacing: -0.055em;

    margin-bottom: 35px;
}

.hero-content h1 span {
    color: var(--accent);
    font-style: italic;
}

.hero-description {
    max-width: 590px;

    color: var(--muted);

    font-size: 1rem;

    margin-bottom: 35px;
}

.hero-buttons {
    display: flex;

    flex-wrap: wrap;

    gap: 12px;

    margin-bottom: 55px;
}

.btn {
    display: inline-flex;

    align-items: center;
    justify-content: center;

    gap: 15px;

    padding: 14px 22px;

    font-size: 0.78rem;

    font-weight: 700;

    transition: var(--transition);
}

.btn-dark {
    background: var(--text);
    color: var(--white);
}

.btn-dark:hover {
    background: var(--accent);
}

.btn-outline {
    border: 1px solid var(--border);
}

.btn-outline:hover {
    border-color: var(--text);
}

.hero-meta {
    display: flex;

    gap: 40px;

    padding-top: 25px;

    border-top: 1px solid var(--border);
}

.hero-meta div {
    display: flex;

    flex-direction: column;

    gap: 3px;
}

.hero-meta strong {
    font-size: 0.82rem;
}

.hero-meta span {
    color: var(--muted);

    font-size: 0.7rem;
}


/* =========================
   HERO VISUAL
   ========================= */

.hero-visual {
    position: relative;

    max-width: 480px;

    margin-left: auto;
}

.portrait-frame {
    position: relative;

    aspect-ratio: 4 / 5;

    overflow: hidden;

    background: var(--surface);
}

.portrait-frame img {
    width: 100%;
    height: 100%;

    object-fit: cover;

    filter: grayscale(100%);

    transition: transform 0.7s ease;
}

.portrait-frame:hover img {
    transform: scale(1.04);
}

.portrait-label {
    position: absolute;

    left: 0;
    bottom: 0;

    width: 100%;

    padding: 18px 20px;

    display: flex;

    justify-content: space-between;

    gap: 10px;

    background: rgba(20, 20, 20, 0.78);

    color: white;

    font-size: 0.62rem;

    letter-spacing: 0.12em;
}

.floating-card {
    position: absolute;

    right: -40px;
    bottom: 40px;

    width: 150px;

    padding: 18px;

    background: var(--accent);

    color: white;

    display: flex;

    flex-direction: column;

    gap: 12px;

    font-size: 0.78rem;

    line-height: 1.4;
}

.floating-number {
    font-family: "Playfair Display", serif;

    font-size: 1.5rem;

    opacity: 0.7;
}


/* =========================
   ABOUT
   ========================= */

.about {
    background: var(--surface);
}

.about-grid {
    display: grid;

    grid-template-columns: 1fr 1fr;

    gap: 100px;
}

.about-text {
    max-width: 600px;
}

.about-text p {
    color: var(--muted);

    margin-bottom: 25px;
}

.about-text .large-text {
    color: var(--text);

    font-family: "Playfair Display", serif;

    font-size: 2rem;

    line-height: 1.25;
}

.about-focus {
    border-top: 1px solid var(--border);
}

.focus-item {
    display: grid;

    grid-template-columns: 45px 1fr;

    column-gap: 15px;

    padding: 28px 0;

    border-bottom: 1px solid var(--border);
}

.focus-item span {
    color: var(--accent);

    font-size: 0.7rem;
}

.focus-item h3 {
    font-family: "Playfair Display", serif;

    font-size: 1.5rem;

    font-weight: 500;

    margin-bottom: 8px;
}

.focus-item p {
    grid-column: 2;

    color: var(--muted);

    font-size: 0.85rem;
}


/* =========================
   EXPERIENCE
   ========================= */

.experience-section {
    background: var(--background);
}

.experience-card {
    padding: 45px;

    border: 1px solid var(--border);

    background: var(--white);
}

.experience-top {
    display: flex;

    justify-content: space-between;

    gap: 30px;

    padding-bottom: 35px;

    border-bottom: 1px solid var(--border);
}

.experience-company {
    color: var(--accent);

    font-size: 0.7rem;

    font-weight: 700;

    letter-spacing: 0.15em;
}

.experience-top h3 {
    font-family: "Playfair Display", serif;

    font-size: clamp(1.8rem, 3vw, 2.8rem);

    font-weight: 400;

    margin-top: 8px;
}

.experience-date {
    color: var(--muted);

    font-size: 0.75rem;
}

.experience-content {
    display: grid;

    grid-template-columns: 100px 1fr;

    gap: 30px;

    padding-top: 35px;
}

.experience-number {
    font-family: "Playfair Display", serif;

    color: var(--accent);

    font-size: 3rem;
}

.experience-content p {
    max-width: 800px;

    color: var(--muted);

    margin-bottom: 18px;
}


/* =========================
   TAGS
   ========================= */

.tag-list {
    display: flex;

    flex-wrap: wrap;

    gap: 8px;

    margin-top: 25px;
}

.tag-list span,
.research-tools span {
    padding: 7px 11px;

    border: 1px solid var(--border);

    color: var(--muted);

    font-size: 0.65rem;

    background: transparent;
}


/* =========================
   PROJECTS
   ========================= */

.projects {
    background: var(--surface);
}

.split-heading {
    display: flex;

    justify-content: space-between;

    align-items: end;

    gap: 50px;
}

.split-heading > p {
    max-width: 350px;

    color: var(--muted);

    font-size: 0.9rem;
}

.project-grid {
    display: grid;

    grid-template-columns: repeat(2, 1fr);

    gap: 25px;
}

.project-card {
    background: var(--background);

    border: 1px solid var(--border);

    transition: transform 0.4s ease;
}

.project-card:hover {
    transform: translateY(-6px);
}

.project-large {
    grid-column: span 2;

    display: grid;

    grid-template-columns: 1.2fr 0.8fr;
}

.project-wide {
    grid-column: span 2;

    display: grid;

    grid-template-columns: 0.8fr 1.2fr;
}

.project-image {
    position: relative;

    min-height: 300px;

    overflow: hidden;

    background: #ddd8d0;
}

.project-large .project-image,
.project-wide .project-image {
    min-height: 390px;
}

.project-image img {
    width: 100%;
    height: 100%;

    position: absolute;

    inset: 0;

    object-fit: cover;

    filter: grayscale(20%);

    transition: transform 0.6s ease;
}

.project-card:hover .project-image img {
    transform: scale(1.04);
}

.project-index {
    position: absolute;

    top: 18px;
    left: 18px;

    width: 40px;
    height: 40px;

    display: grid;
    place-items: center;

    background: var(--white);

    font-size: 0.7rem;

    font-weight: 700;
}

.project-info {
    padding: 35px;
}

.project-category {
    color: var(--accent);

    font-size: 0.67rem;

    font-weight: 700;

    letter-spacing: 0.12em;

    text-transform: uppercase;

    margin-bottom: 12px;
}

.project-info h3 {
    font-family: "Playfair Display", serif;

    font-size: 2rem;

    font-weight: 400;

    margin-bottom: 15px;
}

.project-info > p:not(.project-category) {
    color: var(--muted);

    font-size: 0.85rem;
}


/* =========================
   RESEARCH
   ========================= */

.research {
    background: var(--text);

    color: white;
}

.research .eyebrow {
    color: #c68b95;
}

.research .section-heading h2 em {
    color: #c68b95;
}

.research-feature {
    display: grid;

    grid-template-columns: 0.35fr 1fr;

    gap: 60px;

    padding: 55px 0;

    border-top: 1px solid rgba(255, 255, 255, 0.18);

    border-bottom: 1px solid rgba(255, 255, 255, 0.18);
}

.research-number {
    display: flex;

    flex-direction: column;

    gap: 10px;

    color: rgba(255, 255, 255, 0.55);

    font-size: 0.75rem;

    text-transform: uppercase;

    letter-spacing: 0.12em;
}

.research-number strong {
    font-family: "Playfair Display", serif;

    color: white;

    font-size: 4rem;

    font-weight: 400;
}

.research-label {
    color: #c68b95;

    font-size: 0.7rem;

    letter-spacing: 0.12em;

    text-transform: uppercase;
}

.research-content h3 {
    max-width: 850px;

    font-family: "Playfair Display", serif;

    font-size: clamp(2rem, 4vw, 3.8rem);

    line-height: 1.1;

    font-weight: 400;

    margin: 15px 0 25px;
}

.research-content > p:not(.research-label) {
    max-width: 700px;

    color: rgba(255, 255, 255, 0.65);
}

.research-tools {
    display: flex;

    flex-wrap: wrap;

    gap: 8px;

    margin-top: 30px;
}

.research-tools span {
    border-color: rgba(255, 255, 255, 0.2);

    color: rgba(255, 255, 255, 0.7);
}

.research-list-item {
    display: grid;

    grid-template-columns: 80px 1fr;

    gap: 30px;

    padding: 30px 0;

    border-bottom: 1px solid rgba(255, 255, 255, 0.18);
}

.research-list-item > span {
    color: #c68b95;
}

.research-list-item h3 {
    font-family: "Playfair Display", serif;

    font-size: 1.6rem;

    font-weight: 400;

    margin-bottom: 8px;
}

.research-list-item p {
    color: rgba(255, 255, 255, 0.55);

    font-size: 0.85rem;
}


/* =========================
   SKILLS
   ========================= */

.skills {
    background: var(--background);
}

.skills-grid {
    display: grid;

    grid-template-columns: repeat(4, 1fr);

    border-top: 1px solid var(--border);
    border-bottom: 1px solid var(--border);
}

.skill-column {
    padding: 35px 25px;

    border-right: 1px solid var(--border);
}

.skill-column:last-child {
    border-right: 0;
}

.skill-number {
    color: var(--accent);

    font-size: 0.7rem;
}

.skill-column h3 {
    font-family: "Playfair Display", serif;

    font-size: 1.7rem;

    font-weight: 400;

    margin: 25px 0;
}

.skill-column li {
    color: var(--muted);

    font-size: 0.78rem;

    padding: 8px 0;

    border-bottom: 1px solid var(--border);
}


/* =========================
   EDUCATION
   ========================= */

.education {
    background: var(--surface);
}

.education-timeline {
    border-top: 1px solid var(--border);
}

.education-item {
    display: grid;

    grid-template-columns: 180px 1fr;

    gap: 40px;

    padding: 35px 0;

    border-bottom: 1px solid var(--border);
}

.education-year {
    color: var(--accent);

    font-size: 0.75rem;

    font-weight: 700;
}

.education-place {
    color: var(--muted);

    font-size: 0.75rem;

    text-transform: uppercase;

    letter-spacing: 0.1em;
}

.education-item h3 {
    font-family: "Playfair Display", serif;

    font-size: 2rem;

    font-weight: 400;

    margin: 7px 0;
}

.education-item div > p:last-child {
    color: var(--muted);

    font-size: 0.8rem;
}

.certifications {
    margin-top: 80px;
}

.certification-grid {
    display: grid;

    grid-template-columns: repeat(2, 1fr);

    border-top: 1px solid var(--border);
}

.certification-grid span {
    padding: 20px 0;

    border-bottom: 1px solid var(--border);

    font-size: 0.82rem;

    color: var(--muted);
}

.certification-grid span:nth-child(odd) {
    margin-right: 30px;
}


/* =========================
   CONTACT
   ========================= */

.contact {
    background: var(--accent);

    color: white;

    padding: 150px 0;
}

.contact-wrapper {
    max-width: 1000px;
}

.contact .eyebrow {
    color: rgba(255, 255, 255, 0.6);
}

.contact h2 {
    max-width: 900px;

    font-family: "Playfair Display", serif;

    font-size: clamp(3rem, 7vw, 6.5rem);

    line-height: 0.98;

    font-weight: 400;

    letter-spacing: -0.05em;

    margin-bottom: 30px;
}

.contact h2 em {
    color: white;

    font-style: italic;
}

.contact-wrapper > p:not(.eyebrow) {
    max-width: 560px;

    color: rgba(255, 255, 255, 0.72);

    margin-bottom: 55px;
}

.contact-links {
    border-top: 1px solid rgba(255, 255, 255, 0.3);
}

.contact-link {
    display: grid;

    grid-template-columns: 100px 1fr 30px;

    align-items: center;

    gap: 20px;

    padding: 22px 0;

    border-bottom: 1px solid rgba(255, 255, 255, 0.3);

    transition: var(--transition);
}

.contact-link:hover {
    padding-left: 10px;
}

.contact-link span {
    font-size: 0.7rem;

    text-transform: uppercase;

    letter-spacing: 0.12em;

    color: rgba(255, 255, 255, 0.6);
}

.contact-link strong {
    font-size: 0.9rem;

    font-weight: 500;
}


/* =========================
   FOOTER
   ========================= */

.footer {
    background: #151515;

    color: rgba(255, 255, 255, 0.6);

    padding: 25px 0;
}

.footer-content {
    display: flex;

    justify-content: space-between;

    align-items: center;

    gap: 20px;

    font-size: 0.7rem;
}

.footer a {
    color: white;
}


/* =========================
   BACK TO TOP
   ========================= */

.back-to-top {
    position: fixed;

    right: 25px;
    bottom: 25px;

    width: 45px;
    height: 45px;

    border: 0;

    background: var(--text);

    color: white;

    cursor: pointer;

    opacity: 0;

    pointer-events: none;

    transform: translateY(10px);

    transition: var(--transition);

    z-index: 900;
}

.back-to-top.visible {
    opacity: 1;

    pointer-events: auto;

    transform: translateY(0);
}

.back-to-top:hover {
    background: var(--accent);
}


/* =========================
   SCROLL REVEAL
   ========================= */

.reveal {
    opacity: 0;

    transform: translateY(30px);

    transition:
        opacity 0.7s ease,
        transform 0.7s ease;
}

.reveal.visible {
    opacity: 1;

    transform: translateY(0);
}


/* =========================
   RESPONSIVE — TABLET
   ========================= */

@media (max-width: 1000px) {

    :root {
        --section-padding: 90px;
    }

    .nav-menu {
        gap: 18px;
    }

    .hero-grid {
        gap: 50px;
    }

    .floating-card {
        right: -15px;
    }

    .about-grid {
        gap: 50px;
    }

    .skills-grid {
        grid-template-columns: repeat(2, 1fr);
    }

    .skill-column:nth-child(2) {
        border-right: 0;
    }

    .skill-column:nth-child(-n+2) {
        border-bottom: 1px solid var(--border);
    }

}


/* =========================
   RESPONSIVE — MOBILE
   ========================= */

@media (max-width: 760px) {

    :root {
        --section-padding: 75px;
    }

    .navbar {
        height: 70px;
    }

    .menu-toggle {
        display: block;
    }

    .nav-resume {
        display: none;
    }

    .nav-menu {
        position: absolute;

        top: 70px;
        left: 0;

        width: 100%;

        padding: 25px;

        display: flex;

        flex-direction: column;

        align-items: flex-start;

        gap: 22px;

        background: var(--background);

        border-bottom: 1px solid var(--border);

        transform: translateY(-120%);

        opacity: 0;

        pointer-events: none;

        transition: var(--transition);
    }

    .nav-menu.open {
        transform: translateY(0);

        opacity: 1;

        pointer-events: auto;
    }

    .hero {
        padding-top: 120px;
    }

    .hero-grid {
        grid-template-columns: 1fr;

        gap: 55px;
    }

    .hero-content h1 {
        font-size: clamp(3rem, 14vw, 5rem);
    }

    .hero-meta {
        flex-wrap: wrap;

        gap: 25px;
    }

    .hero-visual {
        width: 90%;

        margin: 0 auto;
    }

    .floating-card {
        right: -10px;

        bottom: 20px;
    }

    .about-grid {
        grid-template-columns: 1fr;

        gap: 60px;
    }

    .split-heading {
        display: block;
    }

    .split-heading > p {
        margin-top: 25px;
    }

    .project-grid {
        grid-template-columns: 1fr;
    }

    .project-large,
    .project-wide {
        grid-column: span 1;

        display: block;
    }

    .project-large .project-image,
    .project-wide .project-image {
        min-height: 300px;
    }

    .experience-card {
        padding: 25px;
    }

    .experience-top {
        flex-direction: column;
        gap: 10px;
    }

    .experience-content {
        grid-template-columns: 1fr;

        gap: 10px;
    }

    .research-feature {
        grid-template-columns: 1fr;

        gap: 30px;
    }

    .research-number {
        flex-direction: row;

        align-items: center;

        gap: 15px;
    }

    .research-number strong {
        font-size: 2rem;
    }

    .research-list-item {
        grid-template-columns: 40px 1fr;

        gap: 15px;
    }

    .skills-grid {
        grid-template-columns: 1fr;
    }

    .skill-column {
        border-right: 0;

        border-bottom: 1px solid var(--border);
    }

    .skill-column:last-child {
        border-bottom: 0;
    }

    .education-item {
        grid-template-columns: 1fr;

        gap: 10px;
    }

    .certification-grid {
        grid-template-columns: 1fr;
    }

    .certification-grid span:nth-child(odd) {
        margin-right: 0;
    }

    .contact {
        padding: 100px 0;
    }

    .contact-link {
        grid-template-columns: 75px 1fr 20px;
    }

    .contact-link strong {
        word-break: break-word;
    }

    .footer-content {
        flex-direction: column;

        align-items: flex-start;
    }

}


/* =========================
   REDUCED MOTION
   ========================= */

@media (prefers-reduced-motion: reduce) {

    html {
        scroll-behavior: auto;
    }

    *,
    *::before,
    *::after {
        transition: none !important;
        animation: none !important;
    }

    .reveal {
        opacity: 1;
        transform: none;
    }

}