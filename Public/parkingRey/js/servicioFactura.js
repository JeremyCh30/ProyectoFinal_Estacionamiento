let id = localStorage.getItem('estacionamiento');
let index = id - 1;
let btnFacturar= document.querySelector('#btnFacturar');

getFacturas();


async function getFacturas() {
    var opciones = {
        method: 'GET'
    };

    fetch("https://localhost:5001/Estacionamientos", opciones)
        .then(response => response.json())
        .then(resultados => {

            console.log(resultados[index]);

            let spanPlaca = document.getElementById('placa');
            let placa = resultados[index].vehiculo.placa;
            spanPlaca.innerHTML = placa;

            let entrada = resultados[index].horaDeEntrada;
            let fecha = new Date();
            let salida = fecha.getHours();

            //let salida = resultados[index].horaDeSalida;
            let thoras = salida - entrada;
            if(thoras==0){
                thoras=1;
            }
            let spanHoras = document.getElementById('horas');
            let tipo = resultados[index].vehiculo.tipo;
            spanHoras.innerHTML = thoras;
            let tipoVehiculo = tipo.toLowerCase();

            


            if (tipoVehiculo == "carro") {
                let montoPagar = thoras * 1000;
                let spanPHora = document.getElementById('phoras');
                spanPHora.innerHTML = 1000;
                let spanPTotal = document.getElementById('ptotal');
                spanPTotal.innerHTML = montoPagar;
                let spanMontoTotal = document.getElementById('total');
                spanMontoTotal.innerHTML = montoPagar;

            } else {
                let montoPagar = thoras * 750;
                let spanPHora = document.getElementById('phoras');
                spanPHora.innerHTML = 750;
                let spanPTotal = document.getElementById('ptotal');
                spanPTotal.innerHTML = montoPagar;
                let spanMontoTotal = document.getElementById('total');
                spanMontoTotal.innerHTML = montoPagar;
            }

        })
        .catch(error => alert('ha ocurrido un error: ' + error));
}
