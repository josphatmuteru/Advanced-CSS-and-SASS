@keyframes moveInLeft {
  0% {
    opacity: 0;
    transform: translateX(-10rem);
  }
  80% {
    transform: translateX(1rem);
  }
  100% {
    opacity: 1;
    transform: translateX(0);
  }
}
@keyframes moveInRight {
  0% {
    transform: translateX(10rem);
  }
  80% {
    transform: translateX(-1rem);
  }
  100% {
    tranform: translateX(0);
  }
}
@keyframes moveInBottom {
  0% {
    opacity: 0;
    transform: translateY(3rem);
  }
  100% {
    tranform: translateY(0);
  }
}
*,
::after,
::before {
  margin: 0;
  padding: 0;
  box-sizing: inherit;
}

html {
  font-size: 62.5%;
}

body {
  box-sizing: border-box;
}

body {
  font-family: "Lato", sans-serif;
  line-height: 1.7;
  color: #777;
  font-size: 1.6rem;
  font-weight: 400;
  padding: 3rem;
}

.heading-primary {
  color: #fff;
  text-transform: uppercase;
  backface-visibility: hidden;
  margin-bottom: 6rem;
}
.heading-primary--main {
  display: block;
  font-size: 6rem;
  letter-spacing: 3.5rem;
  font-weight: 400;
  animation: moveInLeft 1s ease-out;
}
.heading-primary--sub {
  display: block;
  font-size: 2rem;
  font-weight: 700;
  letter-spacing: 1.7rem;
  animation: moveInRight 1s ease-out;
}

.heading-secondary {
  font-size: 3.5rem;
  text-transform: uppercase;
  font-weight: 700;
  display: inline-block;
  background-image: linear-gradient(to right, #7ed56f, #28b485);
  -webkit-background-clip: text;
  color: transparent;
  letter-spacing: 0.2rem;
  transition: all 0.2s;
}
.heading-secondary:hover {
  transform: skewY(2deg) skewX(15deg) scale(1.1);
  text-shadow: 0.5rem 1rem 2rem rgba(0, 0, 0, 0.2);
}

.heading-tertiary {
  font-size: 1.6rem;
  font-weight: 700;
  text-transform: uppercase;
}

.paragraph {
  font-size: 1.6rem;
}
.paragraph:not(:last-child) {
  margin-bottom: 3rem;
}

.u-center-text {
  text-align: center;
}

.u-margin-bottom-big {
  margin-bottom: 8rem;
}

.u-margin-bottom-medium {
  margin-bottom: 4rem;
}

.u-margin-bottom-small {
  margin-bottom: 1.5rem;
}

.section-about {
  background-color: #f7f7f7;
  padding: 25rem 0;
  margin-top: -20vh;
}

.section-features {
  background-color: black;
  background-size: cover;
}

.btn:link, .btn:visited {
  text-transform: uppercase;
  text-decoration: none;
  padding: 1.5rem 4rem;
  display: inline-block;
  border-radius: 10rem;
  transition: all 0.2s;
  position: relative;
  font-size: 1.6rem;
}
.btn:hover {
  transform: translateY(-0.3rem);
  box-shadow: 0 1rem 2rem rgba(0, 0, 0, 0.2);
}
.btn:hover::after {
  transform: scaleX(1.4) scaleY(1.6);
  opacity: 0;
}
.btn:active {
  transform: translateY(-0.1rem);
  box-shadow: 0 0.5rem 0.1rem rgba(0, 0, 0, 0.2);
}
.btn--white {
  background-color: #fff;
  color: #777;
}
.btn--white::after {
  background-color: #fff;
}
.btn::after {
  content: "";
  height: 100%;
  width: 100%;
  display: inline-block;
  position: absolute;
  top: 0;
  left: 0;
  border-radius: 10rem;
  z-index: -1;
  transition: all 0.4s;
}
.btn--animated {
  animation: moveInBottom 0.5s ease-out 0.75s;
  animation-fill-mode: backwards;
}

.btn-text:link, .btn-text:visited {
  color: #55c57a;
  display: inline-block;
  text-decoration: none;
  border-bottom: 1px solid #55c57a;
  padding: 3px;
}
.btn-text:hover {
  background-color: #55c57a;
  color: #fff;
  box-shadow: 0 1rem 2rem rgba(0, 0, 0, 0.15);
  transform: translateY(-2px);
}
.btn-text:active {
  box-shadow: 0 0.5rem 2rem rgba(0, 0, 0, 0.15);
  transform: translateY(0);
}

.composition {
  position: relative;
}
.composition__photo {
  width: 55%;
  box-shadow: 0 1.5rem 4rem rgba(0, 0, 0, 0.4);
  position: absolute;
  z-index: 10;
  outline-offset: 2rem;
  transition: all 0.2s;
}
.composition__photo--p1 {
  left: 0;
  top: -2rem;
}
.composition__photo--p2 {
  right: 0;
  top: 2rem;
}
.composition__photo--p3 {
  left: 20%;
  top: 10rem;
}
.composition__photo:hover {
  outline: 1.5rem solid #55c57a;
  box-shadow: 0 2.5rem 4rem rgba(0, 0, 0, 0.5);
  transform: scale(1.05) translateY(-0.5rem);
  z-index: 20;
}
.composition:hover .composition__photo:not(:hover) {
  transform: scale(0.8);
}

.header {
  height: 95vh;
  background-image: linear-gradient(to right bottom, rgba(126, 213, 111, 0.8), rgba(40, 180, 133, 0.8)), url(../img/hero.jpg);
  background-position: top;
  background-size: cover;
  clip-path: polygon(0 0, 100% 0, 100% 75vh, 0 100%);
  position: relative;
}
.header__logo-box {
  position: absolute;
  left: 4rem;
  top: 4rem;
}
.header__logo {
  height: 3.5rem;
}
.header__text-box {
  position: absolute;
  left: 50%;
  top: 40%;
  transform: translate(-50%, -50%);
  text-align: center;
}

.row {
  max-width: 114rem;
  margin: 0 auto;
  margin-bottom: 8rem;
}
.row:not(:last-child) {
  margin-bottom: 8rem;
}
.row::after {
  content: "";
  display: table;
  clear: both;
}
.row [class^=col-] {
  float: left;
}
.row [class^=col-]:not(:last-child) {
  margin-right: 6rem;
}
.row .col-1-of-2 {
  width: calc((100% - 6rem) / 2);
}
.row .col-1-of-3 {
  width: calc((100% - 2 * 6rem) / 3);
}
.row .col-2-of-3 {
  width: calc(
      2 * ((100% - 2 * 6rem) / 3) + 6rem
    );
}
.row .col-1-of-4 {
  width: calc((100% - 3 * 6rem) / 4);
}
.row .col-2-of-4 {
  width: calc(
      2 * ((100% - 3 * 6rem) / 4) + 6rem
    );
}
.row .col-3-of-4 {
  width: calc(3 * (100% - 3 * 6rem) / 4 + (2 * 6rem));
}

/*
COLORS:

Light green: #7ed56f
Medium green: #55c57a
Dark green: #28b485

*/

/*# sourceMappingURL=style.cs.map */
