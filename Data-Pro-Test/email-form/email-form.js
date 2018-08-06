$(document).ready(function () {

    $('#submitEmail').click(function () {
        $("#form").remove();
        $('#success').show();

        var phone = document.getElementById("phone").value();
        var email = document.getElementById("email").value();
        var name = document.getElementById("name").value();
        var city = document.getElementById("city").value();
        var friend = document.getElementById("friend").value();

        $.ajax({
            type: "POST",
            url: "/Home/sendEmail",
            data: { name: name, phone: phone, email: email, city: city },

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

    });
});