const usuario = document.getElementById('usuario')
const contrasena = document.getElementById('contraseña')
const button = document.getElementById('ingresar')

button.addEventListener('click ', (e) =>{
    e.prevenDefault()
    const dato = {
        usuario: usuario.value,
        contraseña: contraseña.value
}

console.log(dato)
})
