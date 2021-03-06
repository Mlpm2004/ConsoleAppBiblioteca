// <auto-generated />
using ConsoleAppBiblioteca.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsoleAppBiblioteca.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConsoleAppBiblioteca.Entidades.Autor", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Codigo");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Codigo"));

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Nome");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Sobrenome");

                    b.HasKey("Codigo");

                    b.ToTable("Autores", (string)null);
                });

            modelBuilder.Entity("ConsoleAppBiblioteca.Entidades.Categoria", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Codigo");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Codigo"));

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.HasKey("Codigo");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("ConsoleAppBiblioteca.Entidades.Livro", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Codigo");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Codigo"));

                    b.Property<int>("AnoPublicacao")
                        .HasColumnType("integer");

                    b.Property<int>("CodigoAutor")
                        .HasColumnType("int");

                    b.Property<int>("CodigoCategoria")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Titulo");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoAutor");

                    b.HasIndex("CodigoCategoria");

                    b.ToTable("Livros", (string)null);
                });

            modelBuilder.Entity("ConsoleAppBiblioteca.Entidades.Livro", b =>
                {
                    b.HasOne("ConsoleAppBiblioteca.Entidades.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("CodigoAutor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleAppBiblioteca.Entidades.Categoria", "Categoria")
                        .WithMany("Livros")
                        .HasForeignKey("CodigoCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("ConsoleAppBiblioteca.Entidades.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("ConsoleAppBiblioteca.Entidades.Categoria", b =>
                {
                    b.Navigation("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
