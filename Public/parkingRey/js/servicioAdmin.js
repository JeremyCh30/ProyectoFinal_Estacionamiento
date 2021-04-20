getEstacionamientos();
getVehiculos();

async function getEstacionamientos() {

    var opciones = {
        method: 'GET'
    };

        //     // El formato americano lo pondrá en AM/PM
        // console.log(fecha.toLocaleTimeString('en-US'));
        // // El formato español lo pondrá en un formato 24h
        // console.log(fecha.toLocaleTimeString('es-ES'));

    await fetch("https://localhost:5001/Estacionamientos", opciones)
        .then(response => response.json())
        .then(result => {
            hora=new Date();
            nueva=hora.getHours();
            //console.log(nueva); obtener hora 

            var tbody = document.querySelector('#tblEstacionamientos tbody');

            for (var i = 0; i < result.length; i++) {
                var resultados = result[i];

                let fila = tbody.insertRow();
                let celdaLugar = fila.insertCell();
                let celdaPlaca = fila.insertCell();
                let celdaTipo = fila.insertCell();
                let celdaAcciones = fila.insertCell();
                
                if(resultados.vehiculo!=null){
                    celdaLugar.innerHTML = resultados.id;
                    celdaPlaca.innerHTML = resultados.vehiculo.placa;
                    celdaTipo.innerHTML = resultados.vehiculo.tipo;


                    //inicio creacion de boton de Facturar
                    let botonFacturar = document.createElement('a');
                    botonFacturar.href = 'Factura.html';
                    botonFacturar.classList.add('fas');
                    botonFacturar.classList.add('fa-dollar-sign');
                    botonFacturar.classList.add('pay');
                    botonFacturar.setAttribute("title", "Facturar");
                    //botonFacturar.setAttribute("onclick", "CalcularPago("+ resultados.id + ")");
                    botonFacturar.addEventListener('click', Facturacion);
                    botonFacturar.dataset.id_estacionamiento = resultados.id;
                    celdaAcciones.appendChild(botonFacturar);
                
                    //fin creacion de boton de Facturar
                }else{
                    celdaLugar.innerHTML = resultados.id;
                    celdaPlaca.innerHTML = "Disponible";
                    // inicio boton Editar
                    let botonEditar = document.createElement('a');
                    //botonEditar.href = '#';
                    botonEditar.classList.add('fas');
                    botonEditar.classList.add('fa-pencil-alt'); //con esta clase se le dan los estilos en css
                    botonEditar.classList.add('edit');
                    botonEditar.setAttribute("title", "Agregar");
                    botonEditar.dataset.id_estacionamiento = resultados.id;
                    //botonEditar.addEventListener('click', mostrarDatosEdicion);
                    celdaAcciones.appendChild(botonEditar); //editar
                    // fin boton Editar

                }
                


                

                

                

            }
        })

        .catch(error => {
            alert('ha ocurrido un error: ' + error)
        });
}

async function getVehiculos() {

    var opciones = {
        method: 'GET'
    };

    await fetch("https://localhost:5001/Vehiculos", opciones)
        .then(response => response.json())
        .then(result => {
            //console.log(result);

            var tbody = document.querySelector('#tblVehiculos tbody');

            for (var i = 0; i < result.length; i++) {
                var resultados = result[i];

                let fila = tbody.insertRow();
                let celdaPlaca = fila.insertCell();
                let celdaTipo = fila.insertCell();
                let celdaAcciones = fila.insertCell();
                
                if(resultados!=null){
                    celdaPlaca.innerHTML = resultados.placa;
                    celdaTipo.innerHTML = resultados.tipo;

                    //inicio creacion de boton de eliminar
                let botonEliminar = document.createElement('a');
                //botonEliminar.href = '#';
                botonEliminar.classList.add('fas');
                botonEliminar.classList.add('fa-trash-alt');
                botonEliminar.classList.add('delete');
                botonEliminar.setAttribute("title", "Eliminar");
                botonEliminar.dataset.id_vehiculo = resultados.id;
                botonEliminar.setAttribute("onclick", "deleteVehiculo(" + resultados.id + ")");
                celdaAcciones.appendChild(botonEliminar);
                //fin creacion de boton de eliminar
                }else{
                    celdaPlaca.innerHTML = "Vacío";
                }
                


                
                
                
            }
        })

        .catch(error => {
            alert('ha ocurrido un error: ' + error)
        });
}

async function deleteVehiculo(nuevoId) {

    var opciones = {
        method: 'DELETE',
    };  

    await fetch("https://localhost:5001/Vehiculos?id=" + nuevoId, opciones)
        .then(response => response.text())
        .then(result => {
            alert(result);
            getVehiculos();
            
        })
        .catch(error => {
            alert('ha ocurrido un error: ' + error)
        });
}

async function Facturacion(){

    let id_estacionamiento = this.dataset.id_estacionamiento;
    localStorage.setItem('estacionamiento', id_estacionamiento);
    window.location.href = 'Factura.html';
        
}
