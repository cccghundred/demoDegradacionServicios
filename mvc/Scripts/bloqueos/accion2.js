var jqxhr2 = $.ajax("/Home/accion2")
    .done(function () {
        console.log("Terminó 2");
    })
    .fail(function () {
        alert("error");
    })