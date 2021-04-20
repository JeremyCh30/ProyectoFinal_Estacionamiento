getAdministrador();

let inputEmail=document.querySelector('#exampleInputEmail1');
let inputPass=document.querySelector('#pass');
var index=0;


async function getAdministrador() {
    
    
    var opciones = {
        method: 'GET'
    };

    fetch("https://localhost:5001/Administradores", opciones)

        .then(response => response.json())
        .then(resultados => {

            inputEmail.value=resultados[index].usuario;
            inputPass.value=resultados[index].contrasenna;

            
            

        })
        .catch(error => alert('ha ocurrido un error: ' + error));
}