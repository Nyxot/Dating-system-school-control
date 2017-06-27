$(window).load(function () {
    // video block start
    $("#limelightPlayer a").click(function () {
        $(this).siblings(".video-content").addClass("showVideo");
    });
    // video block end
    // shareBlock start
    $("#shareBlock").click(function () {
        $("#shareOption").toggleClass("showShareLink");
        return false;
    });
    $("html").click(function () {
        $("#shareOption").removeClass("showShareLink");
    });
    // shareBlock end
    //carousel
//    var $flexslider = $('#bannerText');
//    $flexslider.flexslider({
//        animation: "slide",
//        directionNav: true,
//        slideshow: false,
//        direction: "vertical",
//        itemHeight: 38,
//        slideshowSpeed: 2500,
//        minItems: 3,
//        controlNav: false,
//        start: function (slider) {
//            slider.pause();
//            slider.manualPause = true;
//            slider.mouseover(function () {
//                slider.manualPause = false;
//                slider.play();
//            });
//            slider.mouseout(function () {
//                slider.manualPause = true;
//                slider.pause();
//            });
//        }
//    });



    var addHoverNext = function () {
        $(".slides li").removeClass("hover");
        $(".slides .flex-active-slide").next().addClass("hover");
    };
    $('#nextLink').mouseover(function () {
        addHoverNext = setInterval(
            function () {
                $(".slides li").removeClass("hover");
                $(".slides .flex-active-slide").next().addClass("hover");
            },
         10);
    }).mouseout(function () {
        $(".slides li").removeClass("hover");
        clearInterval(addHoverNext);
    });


    var addHoverActive = function () {
        $(".slides li").removeClass("active");
        $(".slides .flex-active-slide").addClass("active");
    };
    $('#activeLink').mouseover(function () {
        addHoverActive = setInterval(
            function () {
                $(".slides li").removeClass("active");
                $(".slides .flex-active-slide").addClass("active");
            },
         10);
    }).mouseout(function () {
        $(".slides li").removeClass("active");
        clearInterval(addHoverActive);
    });

    var addHoverPrev = function () {
        $(".slides li").removeClass("hover");
        $(".slides .flex-active-slide").prev().addClass("hover");
    };
    $('#prevLink').mouseover(function () {
        addHoverPrev = setInterval(
            function () {
                $(".slides li").removeClass("hover");
                $(".slides .flex-active-slide").prev().addClass("hover");
            },
         100);
    }).mouseout(function () {
        $(".slides li").removeClass("hover");
        clearInterval(addHoverPrev);
    });
    //    

    var slidePrev;
    $('#prevLink').mouseover(function () {
        slidePrev = setInterval(
            function () {
                $(".flex-direction-nav li a.flex-prev").trigger("click");
            },
            2500);
    }).mouseout(function () {
        clearInterval(slidePrev);
    });
    var slideNext;
    $('#nextLink').mouseover(function () {
        slideNext = setInterval(
            function () {
                $(".flex-direction-nav li a.flex-next").trigger("click");
            },
         2500);
    }).mouseout(function () {
        clearInterval(slideNext);
    });

    $("#nextLink").click(function () {
        window.location.href = $(".slides .flex-active-slide").next().find('a').attr('href');
    });
    $("#activeLink").click(function () {
        window.location.href = $(".slides .flex-active-slide").find('a').attr('href');
    });
    $("#prevLink").click(function () {
        window.location.href = $(".slides .flex-active-slide").prev().find('a').attr('href');
    });
    //carousel
    // for menu
    $("#phoneMenu").click(function () {
        $(this).toggleClass("menuBtn-active");
        $("#subMenu").toggleClass("showMenu");
        $("#bgOverlay").toggleClass("showBg");
    });
    $("#bgOverlay").click(function () {
        $("#phoneMenu").removeClass("menuBtn-active");
        $("#subMenu").removeClass("showMenu");
        $(this).removeClass("showBg");
    });
    // for menu
    // search block start
    $("#closeBtn").click(function () {
        $("#headerSearch").toggleClass("openSearch");
    });
    // search block end
    searchBlock(); // for currency move
    responsiveNav(); // for navigation
});
$(window).scroll(function () {
    // sticky header
    if ($(this).scrollTop() > 250) {
        $('header').addClass("sticky");
    }
    else {
        $('header').removeClass("sticky");
    }
    // sticky header

//    subscribe entery start
//   var stickyTop = $('.columnBlock').offset().top;
//    var rssScroll = ($(window).height()) / 2;
//    var winHeight = $(window).height();
//    var scrollTo = $('.columnBlock').height();
//    var bodyWidth = $(window).width();

//    if (bodyWidth < 991) {
//        if ($(window).scrollTop() >= stickyTop - winHeight) {
//            $('#blogBtn').addClass("showBlog");
//            if ($(window).scrollTop() >= stickyTop + scrollTo - winHeight) {
//                $('#blogBtn').removeClass("showBlog");
//            } else {
//                $('#blogBtn').addClass("showBlog");
//            }
//        } else {
//            $('#blogBtn').removeClass("showBlog");
//        }
//    } else if (bodyWidth >= 991) {
//        if ($(window).scrollTop() >= stickyTop - rssScroll) {
//            $('#blogBtn').addClass("showBlog");
//            if ($(window).scrollTop() >= stickyTop + scrollTo - rssScroll) {
//                $('#blogBtn').removeClass("showBlog");
//            } else {
//                $('#blogBtn').addClass("showBlog");
//            }
//        } else {
//            $('#blogBtn').removeClass("showBlog");
//        }
//    }
    // subscribe entery end
});
$(document).ready(function () {
    $("#phoneMenu").click(function () {
        $(".mobileSearch").toggleClass("showSearch");
    });

    leaderMove(); // for leaders detail move
    // ripple 
    //appends the overlay to each button
    $(".rippleBtn").each(function () {
        $(this).append("<div class='ripple'></div>");
    });


    $(".rippleBtn").click(function (e) {
        var $clicked = $(this);

        //gets the clicked coordinates
        var offset = $clicked.offset();
        var relativeX = (e.pageX - offset.left);
        var relativeY = (e.pageY - offset.top);
        var width = $clicked.width();
        var $ripple = $clicked.find('.ripple');

        //puts the ripple in the clicked coordinates without animation
        $ripple.addClass("notransition");
        $ripple.css({ "top": relativeY, "left": relativeX });
        $ripple[0].offsetHeight;
        $ripple.removeClass("notransition");

        //animates the button and the ripple
        $clicked.addClass("hovered");
        $ripple.css({ "width": width * 2, "height": width * 2, "margin-left": -width, "margin-top": -width });

        setTimeout(function () {
            //resets the overlay and button
            $ripple.addClass("notransition");
            $ripple.attr("style", "");
            $ripple[0].offsetHeight;
            $clicked.removeClass("hovered");
            $ripple.removeClass("notransition");
        }, 300);
    });
    // ripple 


    //raised btn
    var $button_ink = $('.btnRipple'),
      $ink, x, y, ink_diameter;

    $button_ink.on('click', function (e) {
        var $this = $(this);
        $this.removeClass('raised');

        // avoid adding multiple ink elements
        if (!$this.find('.ink').length) { // no ink element added yet
            $this.prepend('<span class="ink"></span>');
            $ink = $this.find('.ink');
        } else { // ink element added
            $ink = $this.find('.ink');
            $ink.removeClass('spill');
        }

        ink_diameter = Math.max($this.outerWidth(), $this.outerHeight());

        // x and y coordinates for ink element
        x = e.pageX - $this.offset().left - (ink_diameter / 2);
        y = e.pageY - $this.offset().top - (ink_diameter / 2);

        $ink.css({
            top: y,
            left: x,
            width: ink_diameter,
            height: ink_diameter
        }).addClass('spill');

        $this.addClass('raised');

    });
    //raised btn end

    techTrendHeight(); // trend tech col height



    (function ($) { $.fn.appear = function (fn, options) { var settings = $.extend({ data: undefined, one: true, accX: 0, accY: 0 }, options); return this.each(function () { var t = $(this); t.appeared = false; if (!fn) { t.trigger('appear', settings.data); return; } var w = $(window); var check = function () { if (!t.is(':visible')) { t.appeared = false; return; } var a = w.scrollLeft(); var b = w.scrollTop(); var o = t.offset(); var x = o.left; var y = o.top; var ax = settings.accX; var ay = settings.accY; var th = t.height(); var wh = w.height(); var tw = t.width(); var ww = w.width(); if (y + th + ay >= b && y <= b + wh + ay && x + tw + ax >= a && x <= a + ww + ax) { if (!t.appeared) t.trigger('appear', settings.data); } else { t.appeared = false; } }; var modifiedFn = function () { t.appeared = true; if (settings.one) { w.unbind('scroll', check); var i = $.inArray(check, $.fn.appear.checks); if (i >= 0) $.fn.appear.checks.splice(i, 1); } fn.apply(this, arguments); }; if (settings.one) t.one('appear', settings.data, modifiedFn); else t.bind('appear', settings.data, modifiedFn); w.scroll(check); $.fn.appear.checks.push(check); (check)(); }); }; $.extend($.fn.appear, { checks: [], timeout: null, checkAll: function () { var length = $.fn.appear.checks.length; if (length > 0) while (length--) ($.fn.appear.checks[length])(); }, run: function () { if ($.fn.appear.timeout) clearTimeout($.fn.appear.timeout); $.fn.appear.timeout = setTimeout($.fn.appear.checkAll, 20); } }); $.each(['append', 'prepend', 'after', 'before', 'attr', 'removeAttr', 'addClass', 'removeClass', 'toggleClass', 'remove', 'css', 'show', 'hide'], function (i, n) { var old = $.fn[n]; if (old) { $.fn[n] = function () { var r = old.apply(this, arguments); $.fn.appear.run(); return r; } } }); })(jQuery);

    $(".animated").appear(function () {
        var b = $(this);
        var c = b.data("animation");
        if (!b.hasClass("visible")) {
            var a = b.data("animation-delay");
            if (a) {
                setTimeout(function () {
                    b.addClass(c + " visible")
                }, a)
            } else {
                b.addClass(c + " visible")
            }
        }
    });

//    var tween = new TimelineMax()
//        .add([
//            TweenMax.to("#circle1", 1, { top: 150, ease: Circ.Quart })
//        ]);

//    var controller = new ScrollMagic.Controller();
//    var scene = new ScrollMagic.Scene({ triggerElement: "#scrollMagic", duration: 500, offset: 130 })
//            .setTween(tween)
//            .addTo(controller);

//    $('#test').waypoint(
//            function (direction) {
//                if (direction === 'down') {
//                    $('#circle1').css("position", "absolute");
//                }
//                else {
//                    //$('#circle1').css("position","fixed");
//                }
//            }, {
//                offset: 480
//            }
//	);

    // video block start
    $("#videoPop").click(function () {
        $("#videoBlock").addClass("showVideo");
        $("#bgOverlay").addClass("showBg");
    });
    $("#closeVideo").click(function () {
        $("#videoBlock").removeClass("showVideo");
        $("#bgOverlay").removeClass("showBg");
    });
    // video block end

    // leaders block start
    function closeTabs() {
        $("#leaderBlock .leaderDetail").slideUp();
        $("#leaderBlock .leaderName").removeClass("active");
    }
    $("#leaderBlock .leaderDetail").slideUp();
    $('.leaderProfile a').click(function (e) {
        var currentAttrValue = $(this).attr('href');
        if ($(e.target).is('.active')) {
            closeTabs();
        } else {
            closeTabs();
            $(this).closest(".leaderName").addClass('active');
            $(currentAttrValue).slideDown();
        }
        e.preventDefault();
    });
});
jQuery(function () {
    $(window).resize(function () {
        searchBlock(); // for currency move
        responsiveNav(); // for navigation
        techTrendHeight(); // trend tech col height
        leaderMove(); // for leaders detail move
    }).resize();
});
function searchBlock() {
    var bodyWidth = $(window).width();
    if (bodyWidth < 991) {
        ///$( "#moveSearch" ).appendTo( "#movedSearch" );
        $("#moveSearch").addClass("mobileSearch");
        $("#bgOverlay").click(function () {
            $(".mobileSearch").removeClass("showSearch");
        });
    }
    else if (bodyWidth >= 991) {
        //$( "#moveSearch" ).appendTo( ".menuBlock" );
        $("#moveSearch").removeClass("mobileSearch");
        $(".mobileSearch").removeClass("showSearch");
    }
}

function responsiveNav() {
    var windowHeight = $(window).height();
    var headerHeight = $("header").height();
    var bodyWidth = $(window).width();
    var navHeight = windowHeight - headerHeight;
    if (bodyWidth < 991) {
        $("#subMenu").css("height", navHeight);
    } else if (bodyWidth >= 991) {
        $("#subMenu").css("height", "auto");
    }
}
//tech height
function techTrendHeight() {
    var trendTechHeight = $("#trendTechBlock .techBlock").width();
    $("#trendTechBlock .techBlock").css("height", trendTechHeight + 20 + "px");
}
//tech height function
// leader apend start
function leaderMove() {
    var bodyWidth = $(window).width();
    if (bodyWidth < 767) {
        $("#timDetail").appendTo("#tim");
    } else if (bodyWidth >= 767) {
        $("#timDetail").appendTo("#allLeaderDetail");
    }
    if (bodyWidth < 767) {
        $("#thomasDetail").appendTo("#thomas");
    } else if (bodyWidth >= 767) {
        $("#thomasDetail").appendTo("#allLeaderDetail");
    }
    if (bodyWidth < 767) {
        $("#markDetail").appendTo("#mark");
    } else if (bodyWidth >= 767) {
        $("#markDetail").appendTo("#allLeaderDetail");
    }
}
// leader apend end        