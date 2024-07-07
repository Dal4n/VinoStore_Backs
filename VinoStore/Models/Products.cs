namespace VinoStore.Models;

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