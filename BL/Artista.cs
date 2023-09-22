using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Artista
    {
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.BRodriguezPruebaTecnica2Entities context = new DL_EF.BRodriguezPruebaTecnica2Entities())
                {

                    var query = context.ArtistaGetAll().ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var registro in query)
                        {
                            ML.Artista artista = new ML.Artista();

                            artista.IdArtista = registro.IdArtista;
                            artista.Nombre = registro.Nombre;
                            artista.ApellidoPaterno = registro.ApellidoPaterno;
                            artista.ApellidoPaterno = registro.ApellidoPaterno;

                            result.Objects.Add(artista);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }

            }
            catch (Exception ex) 
            { 
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;

            }

            return result;
        }

    }
}
