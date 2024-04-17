
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using  Proyecto_1_Pensamiento_Computacional_SEM1;

class Programa
{
    static void Main(string[] args)
    {

        DateTime fechaEntrada = DateTime.Now;
        Console.WriteLine(fechaEntrada);

       Console.WriteLine("Ingrese su nombre: ");
       string nombre = Console.ReadLine();
       Console.WriteLine("Ingrese su apellido: ");
       string apellido = Console.ReadLine();
       Console.WriteLine(""); 
       string opcion;
       Console.WriteLine("Desea NIT para su factura?");
       Console.WriteLine("Si = 1");
       Console.WriteLine("No = 0");
       opcion = Console.ReadLine();
       if (opcion == "1")
       {
        Console.WriteLine("Ingrese su numero de NIT: ");
        int nit= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Su factura estará a nombre del siguiente NIT: " + nit);
       }
       else if (opcion == "0")
       {
        Console.WriteLine("Su factura será Consumidor Final");
       }
       Console.WriteLine("");
       Console.WriteLine("");

        Console.WriteLine("Bienvenido "+ nombre +" "+ apellido + " a Licuados de Fresita");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("");
        string option1;

        int cucharadasAzucar;
        double precioSuplemento;
        double precioAzucarBlanca;
        double precioAzucarMorena;

        
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine("                           Menu Licuados de Fresita                                ");
        Console.WriteLine("-----------------------------------------------------------------------------------");            
        Console.WriteLine("Usted ordeno un licuado de Fresa con leche deslactosada sin azucar de tamaño normal");
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine("Desea modificarlo");
        Console.WriteLine("Si = 1");
        Console.WriteLine("No = 0");
        Console.WriteLine("-----------------------------------------------------------------------------------");
        option1 = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        
        if (option1 == "1")
        {
            string option2;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Desea agregar azucar a su licuado?"); 
            Console.WriteLine("A. Azucar blanca (Q. 0.60)");
            Console.WriteLine("B. Azucar morena (Q. 0.40)");
            Console.WriteLine("C. Suplemento (Q. 0.90)");
            Console.WriteLine("Regresar al menu principal con la tecla ESPACIO");
            option2 = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            
            switch (option2)
            {
                case "A": 
    
                Console.WriteLine("azúcar blanca");
                Console.WriteLine("Ingrese la cantidad de cucharadas de azucar que desea en su pedido (maximo 3)");
                double cucharadasAzucarB = Convert.ToDouble(Console.ReadLine());

                if ( cucharadasAzucarB <=3)
                {
                    Console.WriteLine($"El nuevo precio del pedido es: {(precioAzucarBlanca*cucharadasAzucarB)+precioFijo}" );
                }
                else if (cucharadasAzucarB >3)
                {
                    Console.WriteLine("Error: no puede ingresar mas de tres cucharaditas");
                }
                break;
            
                case "B":
   
                Console.WriteLine("azúcar blanca");
                Console.WriteLine("Ingrese la cantidad de cucharadas de azucar que desea en su pedido (maximo 3)");
                double cucharadasAzucarM = Convert.ToDouble(Console.ReadLine());

                if ( cucharadasAzucarM <=3)
                {
    
                    Console.WriteLine($"El nuevo precio del pedido es: {(precioAzucarMorena*cucharadasAzucarM)+precioFijo;}" );
            
                }
                else if (cucharadasAzucarM >3)
                {
                    Console.WriteLine("Error: no puede ingresar mas de tres cucharaditas");
                }
                break;
            
                case "C":

                Console.WriteLine("azúcar blanca");
                Console.WriteLine("Ingrese la cantidad de cucharadas de azucar que desea en su pedido (maximo 3)");
                double cucharadasAzucarS = Convert.ToDouble(Console.ReadLine());

                if ( cucharadasAzucarS <=3)
                {
    
                    Console.WriteLine($"El nuevo precio del pedido es: {(precioAzucarBlanca*cucharadasAzucarB)+precioFijo}" );
            
                }
                else if (cucharadasAzucarS >3)
                {
                    Console.WriteLine("Error: no puede ingresar mas de tres cucharaditas");
                }
                break;
       

            }

            string option3;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Desea modificar el tipo de leche?"); 
            Console.WriteLine("1. Sin leche(solo con agua)(-Q.3.00)");
            Console.WriteLine("2. Leche entera");
            Console.WriteLine("3. Leche deslactosada");
            Console.WriteLine("4. Leche de soya(+Q.2.00)");
            Console.WriteLine("Regresar al menu principal con la tecla ESPACIO");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            option3 = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            if (option3 == "1")
            {
                Console.WriteLine("Tipo de leche modificado a: Sin leche(solo con agua");
            }
            else if(option3 == "2")
            {
                Console.WriteLine("Tipo de leche modificado a: leche entera");
            }
            else if(option3 == "3")
            {
                Console.WriteLine("Tipo de leche modificado a: leche deslactosada");
            }
            else if(option3 == "4")
            {
                Console.WriteLine("Tipo de leche modificado a: leche deslactosada");
            }
            
            else if(option3 == " ")
            {
                Console.WriteLine("Regresando al menu principal");
            }
            else if (option3 == "0")
            {
                Console.WriteLine("Regresando al menu principal");
            }

            string option4;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Desea agradar su licuado?"); 
            Console.WriteLine("Si = 1");
            Console.WriteLine("No = 0");
            Console.WriteLine("Regresar al menu principal con la tecla ESPACIO");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            option4 = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            if (option4 == "1")
            {
                if (!licuado.Agrandado)
                {
                    licuado.Agrandar();
                    Console.WriteLine("Licuado agrandado exitosamente.");
                }
                else
                {
                    Console.WriteLine("El licuado ya ha sido agrandado anteriormente.");
                }
            }
            else if (option4 == "0")
            {
                Console.WriteLine("No se agrandará el licuado.");
            }
            else if (option4 == "0")
            {
               Console.WriteLine("Regresando al menu principal");
            }
        }        
    }
}   

