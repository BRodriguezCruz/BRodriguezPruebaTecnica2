using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Disco
    {

        public static ML.Result GetById(int idDisco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.BRodriguezPruebaTecnica2Entities context = new DL_EF.BRodriguezPruebaTecnica2Entities())
                {
                
                    var query = context.DiscoGetById(idDisco).SingleOrDefault();


                    if (query != null)
                    {
                        ML.Disco disco = new ML.Disco();

                        disco.IdDisco = query.IdDisco;
                        disco.Titulo = query.Titulo;
                        disco.GeneroMusical = query.GeneroMusical;
                        disco.Duracion = query.Duracion;
                        disco.Anio = query.Anio;
                        disco.Distribuidora = query.Distribuidora;
                        disco.Ventas = query.Ventas;
                        disco.Disponibilidad = query.Disponibilidad;
                        disco.Artsita = new ML.Artista();
                        disco.Artsita.IdArtista = query.IdArtista;
                        disco.Artsita.Nombre = query.NombreArtista;

                        result.Object = disco;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }


            }
            catch(Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }

            return result;

        }
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.BRodriguezPruebaTecnica2Entities context = new DL_EF.BRodriguezPruebaTecnica2Entities())
                {

                    var query = context.DiscoGetAll().ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var registro in query)
                        {
                            ML.Disco disco = new ML.Disco();

                            disco.IdDisco = registro.IdDisco;
                            disco.Titulo = registro.Titulo;
                            disco.GeneroMusical = registro.GeneroMusical;
                            disco.Duracion = registro.Duracion;
                            disco.Anio = registro.Anio;
                            disco.Distribuidora = registro.Distribuidora;
                            disco.Ventas = registro.Ventas;
                            disco.Disponibilidad = registro.Disponibilidad;
                            disco.Artsita = new ML.Artista();
                            disco.Artsita.IdArtista = registro.IdArtista;
                            disco.Artsita.Nombre = registro.NombreArtista;

                        }

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

        public static ML.Result AddEF(ML.Disco disco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.BRodriguezPruebaTecnica2Entities context = new DL_EF.BRodriguezPruebaTecnica2Entities())
                {

                    var query = context.DiscoAdd(disco.Titulo, disco.GeneroMusical, disco.Duracion, disco.Anio, disco.Distribuidora, disco.Ventas, disco.Disponibilidad, disco.Artsita.IdArtista);

                    if(query > 0)
                    {
                        result.Correct=true;
                    }
                    else
                    {
                        result.Correct=false;
                    }

                }

            }
            catch( Exception ex )
            {
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result UpdateEF(ML.Disco disco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.BRodriguezPruebaTecnica2Entities context = new DL_EF.BRodriguezPruebaTecnica2Entities())
                {

                    var query = context.DiscoUpdate(disco.IdDisco,disco.Titulo, disco.GeneroMusical, disco.Duracion, disco.Anio, disco.Distribuidora, disco.Ventas, disco.Disponibilidad, disco.Artsita.IdArtista);

                    if (query > 0)
                    {
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

        public static ML.Result DeleteEF(int idDisco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.BRodriguezPruebaTecnica2Entities context = new DL_EF.BRodriguezPruebaTecnica2Entities())
                {

                    var query = context.DiscoDelete(idDisco);

                    if (query > 0)
                    {
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
