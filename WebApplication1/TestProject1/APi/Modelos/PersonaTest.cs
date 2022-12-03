using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Modelos;

namespace TestProject1.APi.Modelos
{

    [TestClass]
    public class PersonaTest
    {
        [TestMethod]
        public void TestRegistrarPersona()
        {
            string nombre = "Fabian";
            string apellido = "Equise";
            string resultado = "Registrado";
            
            Persona persona = new Persona();
            string mensaje = persona.RegistrarPersona(nombre, apellido);
            Assert.AreEqual(resultado, mensaje);
        }

        [TestMethod]
        public void TestRegistrarPersonaError()
        {
            string nombre = "Fabian";
            string apellido = "Equise";
            string resultado = "Error";

            Persona persona = new Persona();
            string mensaje = persona.RegistrarPersona(nombre, apellido);
            Assert.AreEqual(resultado, mensaje);
        }

    }
}
