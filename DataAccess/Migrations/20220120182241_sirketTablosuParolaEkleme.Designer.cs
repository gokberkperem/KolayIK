// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220120182241_sirketTablosuParolaEkleme")]
    partial class sirketTablosuParolaEkleme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Classes.Harcama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasMaxLength(149)
                        .HasColumnType("nvarchar(149)");

                    b.Property<int>("Durumu")
                        .HasColumnType("int");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("Harcamalar");
                });

            modelBuilder.Entity("Entities.Classes.Izin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Durumu")
                        .HasColumnType("int");

                    b.Property<int?>("OdemeId")
                        .HasColumnType("int");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<int>("Tur")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OdemeId");

                    b.HasIndex("PersonelId");

                    b.ToTable("Izinler");
                });

            modelBuilder.Entity("Entities.Classes.Odeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Miktari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OdemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<int>("Tipi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("Odemeler");
                });

            modelBuilder.Entity("Entities.Classes.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IseAlimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("ParolaTekrari")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int?>("SirketiId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("SirketiId");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("Entities.Classes.Sirket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KurulusTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParolaTekrari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SGKSicilNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UyelikPaketiId")
                        .HasColumnType("int");

                    b.Property<string>("WebSitesi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UyelikPaketiId");

                    b.ToTable("Sirketler");
                });

            modelBuilder.Entity("Entities.Classes.SirketYoneticisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gorevi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParolaTekrari")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SirketId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UyelikPaketTipi")
                        .HasColumnType("int");

                    b.Property<int>("YorumId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SirketId")
                        .IsUnique();

                    b.HasIndex("YorumId")
                        .IsUnique();

                    b.ToTable("SirketYoneticileri");
                });

            modelBuilder.Entity("Entities.Classes.UyelikPaketi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SirketId")
                        .HasColumnType("int");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UyelikPaketleri");
                });

            modelBuilder.Entity("Entities.Classes.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("YazilmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Yorumlar");
                });

            modelBuilder.Entity("Entities.Classes.Zimmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("Zimmetler");
                });

            modelBuilder.Entity("Entities.Classes.Harcama", b =>
                {
                    b.HasOne("Entities.Classes.Personel", "Personel")
                        .WithMany("Harcamalar")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Entities.Classes.Izin", b =>
                {
                    b.HasOne("Entities.Classes.Odeme", "Odeme")
                        .WithMany()
                        .HasForeignKey("OdemeId");

                    b.HasOne("Entities.Classes.Personel", "Personel")
                        .WithMany("Izinler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Odeme");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Entities.Classes.Odeme", b =>
                {
                    b.HasOne("Entities.Classes.Personel", "Personel")
                        .WithMany("Odemeler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Entities.Classes.Personel", b =>
                {
                    b.HasOne("Entities.Classes.Sirket", "Sirketi")
                        .WithMany("Personeller")
                        .HasForeignKey("SirketiId");

                    b.Navigation("Sirketi");
                });

            modelBuilder.Entity("Entities.Classes.Sirket", b =>
                {
                    b.HasOne("Entities.Classes.UyelikPaketi", "UyelikPaketi")
                        .WithMany("Sirketler")
                        .HasForeignKey("UyelikPaketiId");

                    b.Navigation("UyelikPaketi");
                });

            modelBuilder.Entity("Entities.Classes.SirketYoneticisi", b =>
                {
                    b.HasOne("Entities.Classes.Sirket", "Sirketi")
                        .WithOne("Yonetici")
                        .HasForeignKey("Entities.Classes.SirketYoneticisi", "SirketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Classes.Yorum", "Yorumu")
                        .WithOne("SirketYoneticisi")
                        .HasForeignKey("Entities.Classes.SirketYoneticisi", "YorumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sirketi");

                    b.Navigation("Yorumu");
                });

            modelBuilder.Entity("Entities.Classes.Zimmet", b =>
                {
                    b.HasOne("Entities.Classes.Personel", "Personel")
                        .WithMany("Zimmetler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Entities.Classes.Personel", b =>
                {
                    b.Navigation("Harcamalar");

                    b.Navigation("Izinler");

                    b.Navigation("Odemeler");

                    b.Navigation("Zimmetler");
                });

            modelBuilder.Entity("Entities.Classes.Sirket", b =>
                {
                    b.Navigation("Personeller");

                    b.Navigation("Yonetici");
                });

            modelBuilder.Entity("Entities.Classes.UyelikPaketi", b =>
                {
                    b.Navigation("Sirketler");
                });

            modelBuilder.Entity("Entities.Classes.Yorum", b =>
                {
                    b.Navigation("SirketYoneticisi")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
