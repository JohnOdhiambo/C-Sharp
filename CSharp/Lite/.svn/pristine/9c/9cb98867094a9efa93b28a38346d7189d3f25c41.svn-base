


        var images = ["inbox.png", "Desert.jpg", "Hydrangeas.jpg", "Jellyfish.jpg", "Koala.jpg", "Lighthouse.jpg", "Penguins.jpg", "Tulips.jpg"];
    $(function () {
        var i = 0;
        $("#dvImage").css("background-image", "url(images/" + images[i] + ")");
        setInterval(function () {
            i++;
            if (i == images.length) {
                i = 0;
            }
            $("#dvImage").fadeOut("slow", function () {
                $(this).css("background-image", "url(images/" + images[i] + ")");
                $(this).fadeIn("slow");
            });
        }, 1000);
    });
