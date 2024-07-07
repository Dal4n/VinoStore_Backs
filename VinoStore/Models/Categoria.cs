

using System.Text.Json.Serialization;

namespace VinoStore.Models;

public class Categoria
{
   public int? Id { get; set; }
   public string? Nombre { get; set; }
   public string? Descripcion { get; set; }
    
    [JsonIgnore]
   public ICollection<Products>? Productos { get; set; }
}

