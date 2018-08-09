
$(document).ready(function () {

    $('#submitEmail').click(function () {
     

        var phone = $('#phone').val();

        var email = $("#email").val();

        var name = $("#name").val();

        var city = $("#city").val();

        var friend = $("#friend").val();

        var getPost = $("#friend").val();



        $.ajax({
            type: "POST",
            url: "/Recipes/sendEmail",
            
            data: "{ 'name': 'name', 'phone': 'phone', 'email': 'email', 'city': 'city', 'getPost': 'getPost', 'friend': 'friend' }",

            contentType: "application/json; charset=utf-8",
            dataType: "json",

            success: function (response) {
                console.log("submit")
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
        //$("#form").remove();
        //$('#success').show();

    });
});