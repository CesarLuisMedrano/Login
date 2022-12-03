namespace WebApplication1.Modelos
{
    public class Persona
    {
        public string nombre;
        public string apellido;


        public string RegistrarPersona(string nombre, string apellido)
        {
            this.nombre = nombre;  
            this.apellido = apellido;


            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            return "Registrado";
        }
    }
}
