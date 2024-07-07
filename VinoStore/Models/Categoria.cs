<<<<<<< HEAD
﻿

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

=======
﻿namespace VinoStore.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Products> Productos { get; set; }
    }
}
>>>>>>> 37f5c83508c705926643895916e92465517a1994
