var listaEstacionamientos = getEstacionamientos();
mostrarEstacionamientos();

function mostrarEstacionamientos() {
    let tbody = document.querySelector('#tblEstacionamientos tbody');
    tbody.innerHTML = '';

    for (let i = 0; i < listaEstacionamientos.length; i++) {


        let fila = tbody.insertRow();

        let celdaPlaca = fila.insertCell();
        let celdaTipo = fila.insertCell();
        let celdaAcciones = fila.insertCell();

        celdaPlaca.innerHTML = listaEstacionamientos.id;
        celdaTipo.innerHTML = listaEstacionamientos.id;
        celdaAcciones.innerHTML = listaEstacionamientos.id;

        // inicio boton Editar
        let botonEditar = document.createElement('a');
        botonEditar.href = '#';
        botonEditar.classList.add('fas');
        botonEditar.classList.add('fa-pencil-alt'); //con esta clase se le dan los estilos en css
        botonEditar.dataset.id_libro = listaEstacionamientos[i]['_id'];
        botonEditar.addEventListener('click', mostrarDatosEdicion);
        celdaAcciones.appendChild(botonEditar); //editar

        celdaAcciones.appendChild(botonEditar)
        // fin boton Editar

        //inicio eliminar
        let botonEliminar = document.createElement('a');
        botonEliminar.href = '#';
        botonEliminar.classList.add('fas');
        botonEliminar.classList.add('fa-trash-alt');
        botonEliminar.dataset.id_libro = listaEstacionamientos[i]['_id'];
        botonEliminar.addEventListener('click', confirmarEliminar);
        celdaAcciones.appendChild(botonEliminar);
        //fin eliminar
    };

};
