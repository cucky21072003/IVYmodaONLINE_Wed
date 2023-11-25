const imgPositive = document.querySelectorAll(".aspect-ratio-169 img")
    //const imgContainer = document.querySelector(".aspect-ratio-169 img")
    let index = 0
    //console.log(imgPositive)
    imgPositive.forEach(function(image,index){
        image.style.left = index *100 + "%"
    })
function imgSlide (){
    index++;
    if (index == imgPositive.length) {
            index = 0;
        }
            
        // Slide the images
        imgPositive.forEach(function (image, i) {
            image.style.left = "-" + (i - index) * 100 + "%";
          });
        //imgPositive.style.left = "-"+index*100+"%"  
}
setInterval(imgSlide,3000)


/*--------------------------Menu Slidebar cartegory-------------------- */
const itemsliderbar = document.querySelectorAll(".cartegory-left-li")
itemsliderbar.forEach(function(menu,index){
    menu.addEventListener("click",function(){
        menu.classList.toggle("block")
    })
    
})

