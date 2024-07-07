using Microsoft.EntityFrameworkCore;

namespace VinoStore.Models;

public partial class BDProductsContext : DbContext
{
    public BDProductsContext()
    {
    }

    public BDProductsContext(DbContextOptions<BDProductsContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Products>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("Products");
            entity.Property(e => e.Id).HasColumnName("Id_Producto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio");

            entity.Property(e => e.ImagenBase64)
                .HasColumnType("nvarchar(max)")
                .HasColumnName("imagen");

            entity.Property(e => e.CategoriaId).HasColumnName("categoriaId");

            entity.HasOne(d => d.Categoria)
                .WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK_Products_Categorias");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("Categorias");
            entity.Property(e => e.Id).HasColumnName("Id_Categoria");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    public virtual DbSet<Products> Productos { get; set; }
    public virtual DbSet<Categoria> Categorias { get; set; }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
