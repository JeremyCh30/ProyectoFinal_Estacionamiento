let inputUSer = document.querySelector('#user');
let inputPass = document.querySelector('#pass');
let btnIniciar = document.querySelector('#btnIniciar');



async function getAdmin() {

  var opciones = {
    method: 'GET'
  };


  await fetch("https://localhost:5001/Administradores", opciones)
    .then(response => response.json())
    .then(result => {
      for (var i = 0; i < result.length; i++) {

        let user = result[i].usuario;
        let pass = result[i].contrasenna;

        if (inputUSer.value == "" || inputPass.value == "") {
          alert('Por favor verifique los espacios en blancos')
          inputUSer.value="";
          inputPass.value="";
        } else {
          if (inputUSer.value == user && inputPass.value == pass) {
            window.location.href = "Admin.html";
          } else {
            alert('Por favor verifique los datos y vuelva a intentarlo')
            inputUSer.value="";
            inputPass.value="";
          }
        }


      }
    })

    .catch(error => {
      alert('ha ocurrido un error: ' + error)
    });

}

btnIniciar.addEventListener('click', getAdmin)