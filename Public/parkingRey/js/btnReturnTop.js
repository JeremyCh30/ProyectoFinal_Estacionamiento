$(document).ready(function() {
    if($('h1').length>0){
        if (document.createStyleSheet){
            document.createStyleSheet('../css/mc-bootstrap.min.css');
        } 	else {
            $("head").append($('<link rel="stylesheet" href="css/mc-bootstrap.min.css" media="screen" />'));
        }
    }
})
$(window).scroll(function(){$(this).scrollTop()>=200?$("#return-to-top").fadeIn(300):$("#return-to-top").fadeOut(300)});
$("#return-to-top").click(function(){$("body,html").animate({scrollTop:0},50)});
$("a[href^='#']").click(function(t){t.preventDefault();var e=$($(this).attr("href")).offset().top-100;$("body, html").animate({scrollTop:e},100),5});
$(function(){var r=$("#header nav");$(window).scroll(function(){$(window).scrollTop()>=60?(r.removeClass("bg-custom").addClass("bg-custom-scrolled")):(r.removeClass("bg-custom-scrolled").addClass("bg-custom"))})})
document.addEventListener("DOMContentLoaded",function(){var e,n=document.querySelectorAll("img.lazy");function t(){e&&clearTimeout(e),e=setTimeout(function(){var e=window.pageYOffset;n.forEach(function(n){n.offsetTop<window.innerHeight+e&&(n.src=n.dataset.src,n.classList.remove("lazy"))}),0==n.length&&(document.removeEventListener("scroll",t),window.removeEventListener("resize",t),window.removeEventListener("orientationChange",t))},20)}document.addEventListener("scroll",t),window.addEventListener("resize",t),window.addEventListener("orientationChange",t)});