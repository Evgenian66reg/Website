let menuScroll = document.getElementById("menu-scroll");
let aboutUs = document.getElementById("aboutUs-scroll");
let reserve = document.getElementById("reserv-scroll");


menuScroll.addEventListener("click",()=>{
   window.scrollTo({
       top: 2600,
       behavior: 'smooth'
   })
});

aboutUs.addEventListener("click",() =>{
   window.scrollTo({
       top: 880,
       behavior:'smooth'
   })
});

reserve.addEventListener("click",() =>{
   window.scrollTo({
       top: 1380,
       behavior: 'smooth'
   })
});
