$(document).ready(function () {
    
    var modalBack = $("#modal-background");
    var loginForm = $(".login-form");
    var navChild = $("nav.navbar-default").children();

    
    $("#login-button").click( function () {
        modalBack.fadeIn();
        loginForm.fadeIn();
        $("#register-login").css("display", "block");
        $("#recipe-entry").css("display", "none");
    });


    var hideRegisterForm = function() {
        $(".whole-reg-form").css("display", "none");
    };

    modalBack.click(function (ev) {
        if (ev.target === this){
            $(this).fadeOut(hideRegisterForm).delay(500);                      
        };
    });
        
    $(".create").click(function () {
        $(".login-form").css("display", "none");
        $(".whole-reg-form").fadeIn(100);
    });

    $("#create-recipe").click(function () {

        //if (navChild !== "UL") {
            $("#register-login").css("display", "none");
            $("#recipe-entry").css("display", "block");
            modalBack.fadeIn();
        //}
        //else {
        //    alert("Please log in to create a recipe");
        //}
    });

    $("input[type=submit]").click(function(){
        modalBack.fadeOut();
    });

    //------------------------Previous & Next Buttons--------------------//

    $(".next").click(function(){
        $(".step-1").toggleClass("animated fadeOutLeft").css("display","none");
        $(".step-2").css("display", "block").toggleClass("animated bounceIn");
        $("#progressbar li:nth-child(2)").find("span").toggleClass("active");
    });

    $(".submit-register").click(function (){
        modalBack.css("display", "none");
        $(".login-form").css("display", "block");
        $(".whole-reg-form").css("display", "none");
        $(".step-1").toggleClass("animated fadeOutLeft").css("display","block");
        $(".step-2").css("display", "none").toggleClass("animated bounceIn");
        $("#progressbar li:nth-child(2)").find("span").toggleClass("active");
    });

});