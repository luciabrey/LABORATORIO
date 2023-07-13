window.addEventListener('scroll', function() {
    var header = document.getElementById('header');
    var logo = document.getElementById('logo');
    if (window.scrollY > 0) {
      header.classList.add('scrolled');
      logo.style.transform = 'translateX(-200px)'; // Mover el logo fuera del menú
    } else {
      header.classList.remove('scrolled');
      logo.style.transform = 'translateX(0)'; // Volver a la posición original del logo
    }
  });