using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            //********** FASE 1 **********

            //Creamos variables para el nombre
            string nom = "Jordi";
            string cognom1 = "Contreras";
            string cognom2 = "Cuerva";

            //Creamos variables para la fecha de nacimiento
            int dia = 30;
            int mes = 5;
            int any = 1980;

            //Mostramos por pantalla los datos concatenados
            Console.WriteLine("********** FASE 1 **********");
            Console.WriteLine(cognom1 + "" + cognom2 + "" + nom);
            Console.WriteLine(dia + "/" + mes + "/" + any);


            //********** FASE 2 **********

            const int anyTraspas = 1948;
            int intervalAnyTraspas = 4;
            int cont = 0;

            Console.WriteLine();
            Console.WriteLine("********** FASE 2 **********");
            //Llamamos a la función que nos dice el número de años de traspaso entre los años pasados
            NumAnysTraspas(anyTraspas, any, intervalAnyTraspas);



            //********** FASE 3 **********


            bool anyNaixementEsTraspas = false;
            string noEsAnyTraspas = "Aquest any no es de traspàs";
            string esAnyTraspas = "Aquest any es de traspàs";

            Console.WriteLine();
            Console.WriteLine("********** FASE 3 **********");

            //Llamamos a la función que recorre un bucle para decirnos los años de traspaso entre dos años pasados
            //y nos devuelve un bool true o false si any es año de traspaso o no
            anyNaixementEsTraspas = AnysDeTraspas(anyTraspas, any, intervalAnyTraspas);

            //Comprobamos el resultado devuelto por la función e imprimimos el mensaje correspondiente
            if (anyNaixementEsTraspas)
            {
                Console.WriteLine(esAnyTraspas);
            }
            else
            {
                Console.WriteLine(noEsAnyTraspas);
            }


            //********** FASE 4 **********

            string nomComplet;
            string dataNaixement;

            Console.WriteLine();
            Console.WriteLine("********** FASE 4 **********");

            //Concatemos las variables de nombre en la variable de nomComplet 
            nomComplet = nom + " " + cognom1 + " " + cognom2;
            //Concatemos las variables de fecha en la variable de dataNaixement 
            dataNaixement = dia + "/" + mes + "/" + any;
            //Imprimimos por consola los valores
            Console.WriteLine($"El meu nom complet és: {nomComplet}");
            Console.WriteLine($"Vaig neixer el: {dataNaixement}");

            //Imprimimos por pantalla si el año de nacimiento es bisiexto, ya hemos obtenido el resultado en la variable anteriormente
            if (anyNaixementEsTraspas)
            {
                Console.WriteLine("El meu any de naixement és de traspàs");
            }
            else
            {
                Console.WriteLine("El meu any de naixement no és de traspàs");
            }


            //Funcion que nos dice los años de traspaso entre dos fechas y nos dice si any es año de traspaso devolviendo un bool
            static bool AnysDeTraspas(int anyTraspas, int any, int intervalAnyTraspas)
            {
                bool anyNaixementEsTraspas = false;
                int cont = 0;
                int iteradorAnys = anyTraspas;
                
                
                for(int i = iteradorAnys; i <= any; i += intervalAnyTraspas)
                {
                    if (i == any)
                    {
                        anyNaixementEsTraspas = true;
                    }

                    Console.WriteLine("iterador anys es " + i);
                    cont++;
                    
                }
                Console.WriteLine("Hi han " + cont + " anys de traspas entre " + anyTraspas + " i " + any);
                return anyNaixementEsTraspas;            

            }


            //Función que calcula y dice el número de años de traspaso entre 2 años pasados como parámetro
            static void NumAnysTraspas(int anyTraspas, int any, int intervalAnyTraspas)
            {
                int numAnysTraspas;
                numAnysTraspas = (any - anyTraspas) / intervalAnyTraspas;
                Console.WriteLine($"El número de años de traspaso entre {anyTraspas} y {any} es {numAnysTraspas}");
            }
        }
    }
}
