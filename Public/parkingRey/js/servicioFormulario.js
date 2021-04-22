let id = localStorage.getItem('estacionamiento');
let index = id - 1;
//getEstacionamiento();
//putEstacionamiento();

let inputPlaca = document.querySelector('#placa');
let inputTipo = document.querySelector('#tipo');
let btnEnviar = document.querySelector('#btnSubmit');



function getEstacionamiento() {
    var opciones = {
        method: 'GET'
    };

    fetch("https://localhost:5001/Estacionamientos", opciones)
        .then(response => response.json())
        .then(resultados => {

            if (resultados[index].vehiculo == null) {
                let idLugar = resultados[index].id;
                let fecha = new Date();
                let hora = fecha.getHours();
                plac = inputPlaca.value;
                let placa = plac.toUpperCase();
                let tipo = inputTipo.value;
                let tipoV = tipo.toLowerCase();

                putEstacionamiento(idLugar, hora, placa, tipoV)
                //window.location.href = 'Admin.html';


            } else {
                console.log("Lugar Ocupado");
            }

        })
        .catch(error => alert('ha ocurrido un error: ' + error));

}

async function putEstacionamiento(pidLugar, phora, pplaca, ptipoV) {
    //alert(pidLugar+", "+phora+", "+pplaca+", "+ptipoV);

    var estacionamientoEditar = {
        "id": +pidLugar,
        "horaDeEntrada": +phora,
        "numeroPosicion": +pidLugar,
        "vehiculo": {
            "placa": pplaca,
            "tipo": ptipoV
        },
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
            alert("Se agregó el vehículo el en espacio seleccionado");
            window.location.href = 'Admin.html';
        })
        .catch(error => console.log('error: ' + error));
}



btnEnviar.addEventListener('click', getEstacionamiento)