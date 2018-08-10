$(document).ready(function () {

    $('#submitEmail').click(function () {
        $("#form").remove();
        $('#success').show();

        var phone = $("#phone").value();
        var email = $("#email").value();
        var name = $("#name").value();
        var city = $("#city").value();
       // var friend = $("#friend").value();

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