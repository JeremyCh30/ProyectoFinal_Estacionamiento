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
            if(placa==null){
                window
            }
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
        .catch(error => console.log('ha ocurrido un error: ' + error));
}

async function delEstacionamiento() {
    //alert(pidLugar+", "+phora+", "+pplaca+", "+ptipoV);

    var estacionamientoEditar = {
        "id": +id,
        "horaDeEntrada": 0,
        "numeroPosicion": +id,
        "horaDeSalida": 0,
        "cobro": 0
    }
    var valoresAGuardar = JSON.stringify(estacionamientoEditar);

    var encabezado = {
        'Content-Type': 'application/json'
    }

    var opciones = {
        method: 'PUT',
        headers: encabezado,
        body: valoresAGuardar
    };

    fetch("https://localhost:5001/Estacionamientos", opciones)
        .then(response => response.text())
        .then(result => {
            alert("Se ha facturado el vehículo");
            window.location.href = 'Admin.html';
        })
        .catch(error => console.log('error: ' + error));
}

btnFacturar.addEventListener('click', delEstacionamiento)