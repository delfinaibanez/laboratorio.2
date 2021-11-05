using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15
{
    abstract class Electrodomestico
    {

        protected double precioBase;
        protected String color;
        protected String consumoElectrico;
        protected int peso;

        //Constructor con todos los atributos
        protected Electrodomestico(double precioBase, string color, string consumoElectrico, int peso)
        {
            this.precioBase = precioBase;
            comprobarColor(color);
            comprobarConsumoEnergetico(consumoElectrico);
            this.peso = peso;
        }
        //Constructor solo con parametros precio y peso
        protected Electrodomestico(double precioBase, int peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }
        //Constructor vacio por "defecto"
        protected Electrodomestico()
        {

        }


        //gets
        public double getprecioBase()
        {
            return this.precioBase;
        }

        public String getcolor()
        {
            return this.color;
        }

        public String getconsumoElectrico()
        {
            return this.consumoElectrico;
        }

        public int getpeso()
        {
            return this.peso;
        }


        //Metodos que implementa la clase
        void comprobarConsumoEnergetico(String letra)
        {

            if (letra != "A" && letra != "B" && letra != "C" && letra != "D" && letra != "E" && letra != "F")
            {
                letra = "F";
            }
            else
            {
                this.consumoElectrico = letra;
            }

            Console.WriteLine("El consumo electrico es de : "+letra);
        }

        void comprobarColor(String color)
        {
            int opcion;
            Console.WriteLine("Ingrese color");
            opcion = Convert.ToInt32(Console.ReadLine());


            if (opcion == 1)
            {
                color = "blanco";
            }
            if (opcion == 2)
            {
                color = "negro";
            }
            if (opcion == 3)
            {
                color = "rojo";
            }
            if (opcion == 4)
            {
                color = "azul";
            }
            if (opcion == 5)
            {
                color = "gris";
            }

            Console.WriteLine("Color: "+color);



        }


        public void precioFinal()
        {
            Console.WriteLine("Ingrese consumo electrico de la A a la F");
            consumoElectrico = Console.ReadLine();
            double precio = 0;
            switch (consumoElectrico)
            {
                case "A":
                    this.precioBase += 100;
                    break;
                case "B":
                    this.precioBase += 80;
                    break;
                case "C":
                    this.precioBase += 60;
                    break;
                case "D":
                    this.precioBase += 50;
                    break;
                case "E":
                    this.precioBase += 30;
                    break;
                case "F":
                    this.precioBase += 10;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Ingrese peso del producto");
            peso = Convert.ToInt32(Console.ReadLine());

            if (peso > 00 && peso <= 19)
            {
                precio += 10;
            }
                

            if (peso > 19 && peso <= 49)
            {
                precio += 50;
            }
                

            if (peso > 49 && peso <= 79)
            {
                precio += 800;
            }
                

            if (peso >= 80)
            {
                precio += 100;
            }



            precio += this.precioBase;
            this.precioBase = precio;

            

        }









    }
}
