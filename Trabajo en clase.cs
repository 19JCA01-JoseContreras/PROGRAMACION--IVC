//Contar cuantas personas son mayores de edad
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DATOS ACADEMICOS\n Nombre: Jose Contreras"+ "  \nGrado: IV C"+ "\nCave:7");

        //crear e inicializar el arreglo
        int[] edadPersonas = new int[7];
        int cantidadPersonasMayores = 0;
        int cantidadPersonasMenores = 0;
        int cantidadPersonas = 0;

        //Llenar el arreglo
        for (int i = 0; i < edadPersonas.Length; i++)
        {
            Console.WriteLine("Ingrese la edad de la persona " +(i+1)+ ": ");
            edadPersonas[i] = Convert.ToInt32(Console.ReadLine());

            if (edadPersonas[i] >=18)
            {
                cantidadPersonasMayores++;
                //cantidadPersonasMAyores=cantidadPersonasMayores+1
            }
            else
            {
                cantidadPersonasMenores++;
            }
            cantidadPersonas++;
        }
        //resultado
        Console.WriteLine();
        Console.WriteLine("Cantidad de mayores de edad: " + cantidadPersonasMayores);
        Console.WriteLine("Cantidad de mayores de edad: " + cantidadPersonasMenores);
        Console.WriteLine("Cantidad de mayores de edad: " + cantidadPersonas);
    }
}
