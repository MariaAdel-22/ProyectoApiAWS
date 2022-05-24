using ProyectoApiAWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoApiAWS.Repositories
{
    public class RepositoryCoches
    {
        public List<Coche> coche;
        public RepositoryCoches() {

            List<Coche> coches = new List<Coche>
            {
                new Coche{ Marca="Hyundai",Modelo="1.2 MPI KLASS",Imagen="https://d1eip2zddc2vdv.cloudfront.net/dphotos/750x400/12904948-1602182075.jpeg"},
                new Coche{ Marca="Mercedes",Modelo="Clase A",Imagen="https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/2018_Mercedes-Benz_A200_AMG_Line_Premium%2B_1.3_Front.jpg/250px-2018_Mercedes-Benz_A200_AMG_Line_Premium%2B_1.3_Front.jpg"}
            };

            this.coche = coches;
        }

        public List<Coche> GetCoches() {

            return this.coche;
        }

        public Coche BuscarCoche(string Marca) {

            Coche nuevoCoche= new Coche();

            foreach (Coche coche in this.coche) {

                if (coche.Marca == Marca)
                {

                    nuevoCoche = coche;
                }
            }

            return nuevoCoche;
        }

        public void InsertarCoche(string Marca,string Modelo,string Imagen) {

            Coche coche = new Coche { Marca = Marca, Modelo = Modelo, Imagen = Imagen };

            this.coche.Add(coche);
        }

        public void ModificarCoche(string Marca, string Modelo, string Imagen)
        {

            Coche coche = BuscarCoche(Marca);

            coche.Modelo = Modelo;
            coche.Imagen = Imagen;

        }

        public void EliminarCoche(string Marca) {

            Coche coche = BuscarCoche(Marca);

            this.coche.Remove(coche);
        }
    }
}
