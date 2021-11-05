using System;
namespace CarritoDeCompras
{
    public class Menu
    {
        private int opcion;
        private int cantidad;

        public void MostrarMenu(Camisas camisas, Carrito carrito)
        {
            do
            {
                Console.WriteLine("*****************************************************");
                Console.WriteLine("bienvenido al Menu principal");
                Console.WriteLine("Elija una opcion:");
                Console.WriteLine("(1) Agregar camisas al carrito");
                Console.WriteLine("(2) Eliminar camisas del carrito");
                Console.WriteLine("(3) Salir del programa ");
                Console.WriteLine("(4)  comprar");
                Console.WriteLine("******************************************************");

                Console.WriteLine("******************************************************-");
                Console.WriteLine("'  '- Cantidad de camisas en el carro de compras: " + carrito.Contador);
                Console.WriteLine("'  '- Precio unitario: " + camisas.GetPrecioUnidad());
                Console.WriteLine("'  '- Precio total sin descuento: $" + carrito.Total);
                Console.WriteLine("'  '- Descuento del: " + (carrito.Descuento * 100) + "%");
                Console.WriteLine("'  '-  el Precio final con descuento: $" + carrito.CuentaFinal);
                Console.WriteLine("Ingrese segun corresponda: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Cuantas camisas desea añadir?");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Usted agregó:" + cantidad + "camisas");
                            carrito.Contador = carrito.Contador + cantidad;
                            Console.WriteLine("--------------------------------------------------");
                            break;

                        case 2:
                            if (cantidad > 0)
                            {
                                Console.WriteLine("Cuantas camisas desea eliminar?");
                                try
                                {
                                    int eliminadas = Convert.ToInt32(Console.ReadLine());
                                    if (eliminadas <= cantidad && eliminadas > 0)
                                    {
                                        cantidad = cantidad - eliminadas;
                                        carrito.Contador = cantidad;

                                    }
                                }
                                catch { }
                            }
                            break;


                        case 3:
                            char salida;
                            Console.WriteLine("Confirme si quiere salir del programa. Coloque S (Si) o N (No)");
                            try
                            {
                                salida = Convert.ToChar(Console.ReadLine()[0]);
                                salida = char.ToUpper(salida);

                                if (salida == 'S')
                                {
                                    Console.WriteLine("Usted está saliendo del programa. Que tenga buen dia");
                                    Environment.Exit(0);
                                }
                                else if (salida == 'N')
                                {
                                    opcion = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Opcion incorrecta");
                                    opcion = 0;
                                }
                            }
                            catch { }
                            break;

                        case 4:
                            char compra;
                            if (carrito.Contador != 0)
                            {
                                Console.WriteLine("¿Desea realizar la compra? Coloque S (Si) o N (No)");
                                try
                                {
                                    compra = Convert.ToChar(Console.ReadLine()[0]);
                                    compra = Char.ToUpper(compra);

                                    if (compra == 'S')
                                    {
                                        Console.WriteLine("Su compra se realizó exisosamente");
                                        Console.WriteLine("El programa se cerrará. Gracias por su compra");
                                        Environment.Exit(0);
                                    }
                                    else if (compra == 'N')
                                    {
                                        opcion = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se reconoció opción");
                                        opcion = 0;
                                    }

                                }
                                catch (NullReferenceException)
                                {
                                    Console.WriteLine("Debe ingresar S para Si, N para No");
                                }

                            }
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("se encontro un error porfavor Debe ingresar un numero positivo");
                }

            } while (opcion != 4);
        }
    }
}
