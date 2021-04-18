getEstacionamientos();

async function getEstacionamientos() {

    var opciones = {
        method: 'GET'
    }; 

    await fetch("https://localhost:5001/Estacionamientos", opciones)
        .then(response => response.json())
        .then(result => {
            console.log(result);

            var tbody = document.querySelector('#tblEstacionamientos tbody');

            for (var i= 0; i<result.length; i++){
                var resultados = result[i];

                let fila = tbody.insertRow();
                let celdaLugar = fila.insertCell();
                let celdaPlaca = fila.insertCell();
                let celdaTipo = fila.insertCell();
                let celdaAcciones = fila.insertCell();

                celdaLugar.innerHTML = resultados.id;
                celdaPlaca.innerHTML = resultados.vehiculo.placa;
                celdaTipo.innerHTML = resultados.vehiculo.tipo;
                

                // inicio boton Editar
                let botonEditar = document.createElement('a');
                //botonEditar.href = '#';
                botonEditar.classList.add('fas');
                botonEditar.classList.add('fa-pencil-alt'); //con esta clase se le dan los estilos en css
                botonEditar.classList.add('edit');
                botonEditar.dataset.id_libro = resultados.id;
                //botonEditar.addEventListener('click', mostrarDatosEdicion);
                celdaAcciones.appendChild(botonEditar); //editar
                // fin boton Editar

                //inicio creacion de boton de eliminar
                let botonEliminar = document.createElement('a');
                //botonEliminar.href = '#';
                botonEliminar.classList.add('fas');
                botonEliminar.classList.add('fa-trash-alt');
                botonEliminar.classList.add('delete');
                botonEliminar.dataset.id_libro = resultados.id;
                celdaAcciones.appendChild(botonEliminar);
                //fin creacion de boton de eliminar

            }
        })
            
        .catch(error => {
            alert('ha ocurrido un error: '+ error)
        });
}