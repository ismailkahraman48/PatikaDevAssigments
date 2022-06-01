const input = prompt('Adınızı Giriniz');
const city = prompt('Şehir giriniz','Istanbul') // örnek: Madrid giriniz
const name = document.getElementById('myName');
const clock = document.getElementById('myClock');




name.innerHTML = input;



function showTime(){
    var dateString = new Date().toLocaleString("TR", {timeZone: `Europe/${city}`});
    clock.innerHTML = dateString;
}

  
setInterval(showTime, 1000);

