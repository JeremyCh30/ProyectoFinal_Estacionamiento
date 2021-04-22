/*getAdministrador();

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
}*/
var email="rey161509@gmail.com";
var pass="KND.cuatro";
let inputEmail=document.querySelector("#exampleInputEmail1");
let inputPass=document.querySelector("#pass");
function validacion() {
    if (inputEmail.value==email) {
      // Si no se cumple la condicion...
      alert('Ingrese email correcto');
      return false;
    }
    else if (inputPass.value==pass) {
      // Si no se cumple la condicion...
      alert('Ingrese contraseña valida');
      return false;
    }
    // Si el script ha llegado a este punto, todas las condiciones
    // se han cumplido, por lo que se devuelve el valor true
    return true;
  }