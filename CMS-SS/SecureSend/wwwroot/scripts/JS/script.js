$(document).ready(function(){
    $('.burger').click(function(){
      $('.item').toggleClass("show");
      $('ul li').toggleClass("hide");
    });
  });
                        