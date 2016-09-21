var Carousel = Carousel || {};

(function ($, document, undefined) {
    Carousel.init = function () {
        $("#owl-demo").owlCarousel({

            autoPlay: 3000, //Set AutoPlay to 3 seconds

            items: 4,
            itemsDesktop: [1199, 3],
            itemsDesktopSmall: [979, 3]

        });
    };

    $(function () {
        console.log("Carousel.init()");
        Carousel.init();
    });

})(jQuery, document);