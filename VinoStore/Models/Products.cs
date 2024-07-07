<<<<<<< HEAD
﻿namespace VinoStore.Models;

public class Products
{
    public int? Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public decimal? Precio { get; set; }
    public string? ImagenBase64 { get; set; }
    public int? CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }
}
=======
﻿namespace VinoStore.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string ImagenURL { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
>>>>>>> 37f5c83508c705926643895916e92465517a1994
