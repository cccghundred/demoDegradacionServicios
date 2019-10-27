var jqxhr = $.ajax("/Home/accion1")
    .done(function () {
        console.log("Terminó 1");
    })
    .fail(function () {
        alert("error");
    })