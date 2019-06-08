// Wrap every letter in a span
$('.ml14 .letters').each(function(){
	$(this).html($(this).text().replace(/([^\x00-\x80]|\w)/g, "<span class='letter'>$&</span>"));
  });
  
  anime.timeline({loop: false})
	.add({
	  targets: '.ml14 .line',
	  scaleX: [0,1],
	  opacity: [0.5,1],
	  easing: "easeInOutExpo",
	  duration: 1300
	}).add({
	  targets: '.ml14 .letter',
	  opacity: [0,1],
	  translateX: [40,0],
	  translateZ: 0,
	  scaleX: [0.3, 1],
	  easing: "easeOutExpo",
	  duration: 1200,
	  offset: '-=600',
	  delay: function(el, i) {
		return 150 + 25 * i;
	  }
	}).add({
	  targets: '.ml14',
	  opacity: 0,
	  duration: 1000,
	  easing: "easeOutExpo",
	  delay: 10000
});

$('.ml15 .letters').each(function(){
	$(this).html($(this).text().replace(/([^\x00-\x80]|\w)/g, "<span class='letter'>$&</span>"));
  });
  
  anime.timeline({loop: false})
	.add({
	  targets: '.ml14 .line',
	  scaleX: [0,1],
	  opacity: [0.5,1],
	  easing: "easeInOutExpo",
	  duration: 1300
	}).add({
	  targets: '.ml14 .letter',
	  opacity: [0,1],
	  translateX: [40,0],
	  translateZ: 0,
	  scaleX: [0.3, 1],
	  easing: "easeOutExpo",
	  duration: 1200,
	  offset: '-=600',
	  delay: function(el, i) {
		return 150 + 25 * i;
	  }
	}).add({
	  targets: '.ml14',
	  opacity: 0,
	  duration: 1000,
	  easing: "easeOutExpo",
	  delay: 10000
});

$(document).ready(function() {
	$('.col-lg-3').magnificPopup({
		delegate: 'a',
		type: 'image',
		closeOnContentClick: false,
		closeBtnInside: false,
		mainClass: 'mfp-with-zoom mfp-img-mobile',
		image: {
			verticalFit: true,
			titleSrc: function(item) {
				return item.el.attr('title');
			}
		},
		gallery: {
			enabled: true
		},
		zoom: {
			enabled: true,
			duration: 300, // don't foget to change the duration also in CSS
			opener: function(element) {
				return element.find('img');
			}
		}
		
	});
});