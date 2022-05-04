using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBAR2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            using (BarDbEntities db = new BarDbEntities())
            {
                int num = 0;
              
                Console.WriteLine("Bienvenidos a mi BAR : -EL CHAPARRAAL-");
                Console.WriteLine("Seleccione una opcion ");
                Console.WriteLine("1. Insertar Producto \n" +
                    "2. Editar Un Producto \n" +
                    "3. Eliminar Un Producto \n" +
                    "4. Salir");
                
                num = Convert.ToInt32 (Console.ReadLine());
                
                switch (num)
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Producto oProducto = new Producto();
                            Console.WriteLine("Insertar Nombre");
                            oProducto.nomProd = Console.ReadLine();
                            Console.WriteLine("Inserte una descripcion");
                            oProducto.descripcion = Console.ReadLine();
                            Console.WriteLine("Inserte un precio");
                            oProducto.precio = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Ingrese una cantidad");
                            oProducto.cantidad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese un estado");
                            oProducto.estado = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Producto Ingresado Correctamente");

                            
                           
                            Console.WriteLine("Nombre: " + oProducto.nomProd);
                            Console.WriteLine("Descripcion: " + oProducto.descripcion);
                            Console.WriteLine("Precio: " + oProducto.precio);
                            Console.WriteLine("Cantidad: " + oProducto.cantidad);
                            Console.WriteLine("Estado: " + oProducto.estado);

                            Console.ReadLine();


                            db.Productoes.Add(oProducto);
                            db.SaveChanges();

                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Producto oProducto = new Producto();
                            Console.WriteLine("Ingrese el id del producto que desea actualizar");
                            oProducto.idProducto = Convert.ToInt32(Console.ReadLine());
                            oProducto = db.Productoes.Find(oProducto.idProducto);
                            Console.WriteLine("Ingrese un nuevo  nombre");
                            oProducto.nomProd = Console.ReadLine();
                            Console.WriteLine("Ingrese una  nueva descripcion");
                            oProducto.descripcion = Console.ReadLine();
                            Console.WriteLine("Ingrese un precio");
                            oProducto.precio = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Ingrese una nueva cantidad");
                            oProducto.cantidad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese un nuevo estado");
                            oProducto.estado = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Se han realizado los cambios exitosamente");
                            db.Entry(oProducto).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();


                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Producto oProducto = new Producto();
                            Console.WriteLine("Seleccione el ID del producto que desea eliminar ");
                            oProducto.idProducto = Convert.ToInt32(Console.ReadLine());
                            db.Entry(oProducto).State = System.Data.Entity.EntityState.Deleted;
                            Console.WriteLine("Producto Eliminado ");
                            db.SaveChanges();
                            break;
                        }

                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Environment.Exit(0);

                            break;
                        }
                       
                }



                

               
            }
        }
    }
}
