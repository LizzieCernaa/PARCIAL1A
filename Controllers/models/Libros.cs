namespace PARCIAL1A.Controllers.models
{
    public class Libros
    {

            public int Id { get; set; }
            public string Titulo { get; set; }
     }


        public class AutoresLibro
        {
            public int AutorId { get; set; }
            public int LibroId { get; set; }
        }

}
