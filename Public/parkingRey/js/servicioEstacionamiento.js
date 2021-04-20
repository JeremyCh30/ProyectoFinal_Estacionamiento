getEstacionamientos();
async function getEstacionamientos() {

    var opciones = {
        method: 'GET'
    };


    await fetch("https://localhost:5001/Estacionamientos", opciones)
        .then(response => response.json())
        .then(result => {
 
            console.log(result);
            var contenedor = document.querySelector('.contenedor');

            for (var i = 0; i < result.length; i++) {
                var resultados = result[i];
                
                if(resultados.vehiculo!=null){
                    let disponible = document.createElement('div');
                    disponible.classList.add('tarjeta');
                    disponible.classList.add('disp'); 
                    let icono=document.createElement('i');
                    icono.classList.add('fas');
                    icono.classList.add('fa-car');
                    disponible.appendChild(icono);
                    contenedor.appendChild(disponible);
                }else{
                    let ocupado = document.createElement('div');
                    ocupado.classList.add('tarjeta');
                    ocupado.classList.add('ocup'); 
                    let icono=document.createElement('i');
                    icono.classList.add('fas');
                    icono.classList.add('fa-ban');
                    ocupado.appendChild(icono);
                    contenedor.appendChild(ocupado);
                }
            }
        })

        .catch(error => {
            alert('ha ocurrido un error: ' + error)
        });
}