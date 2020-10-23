using System;
using Day2Day.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Day2Day.Infrastructure.Data
{
    public partial class PRY2020112V10Context : DbContext
    {
        public PRY2020112V10Context()
        {
        }

        public PRY2020112V10Context(DbContextOptions<PRY2020112V10Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Diary> Diary { get; set; }
        public virtual DbSet<Specialist> Specialist { get; set; }
        public virtual DbSet<Pacient> Pacient { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Tutor> Tutor { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diary>(entity =>
            {
                entity.HasKey(e => e.DiaryId)
                    .HasName("diario_pk");

                entity.ToTable("diario");

                entity.Property(e => e.DiaryId).HasColumnName("iddiario");

                entity.Property(e => e.DateTime)
                    .HasColumnName("fecha_hora")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PacientId).HasColumnName("paciente_idpaciente");

                entity.Property(e => e.IsDone).HasColumnName("realizado");

                entity.Property(e => e.Result)
                    .HasColumnName("resultado")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasColumnName("texto")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pacient)
                    .WithMany(p => p.Diaries)
                    .HasForeignKey(d => d.PacientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("diario_paciente_fk");
            });

            modelBuilder.Entity<Specialist>(entity =>
            {
                entity.HasKey(e => e.SpecialistId)
                    .HasName("especialista_pk");

                entity.ToTable("especialista");

                entity.Property(e => e.SpecialistId).HasColumnName("idespe");

                entity.Property(e => e.LastName)
                    .HasColumnName("apellidos")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Job)
                    .HasColumnName("cargo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("contrasenia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("correo")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDescription)
                    .HasColumnName("des_estado")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasColumnName("empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Speciality)
                    .HasColumnName("especialidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("estado");

                entity.Property(e => e.Birthday)
                    .HasColumnName("fecha_nacimiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CollegeNumber)
                    .HasColumnName("num_colegiatura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasColumnName("num_doc_identidad")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .HasColumnName("tipo_documentacion")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pacient>(entity =>
            {
                entity.HasKey(e => e.PacientId)
                    .HasName("paciente_pk");

                entity.ToTable("paciente");

                entity.Property(e => e.PacientId).HasColumnName("idpaciente");

                entity.Property(e => e.LastName)
                    .HasColumnName("apellidos")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("contrasenia")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("correo")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasColumnName("departamento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDescription)
                    .HasColumnName("des_estado")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StudyLevelDescription)
                    .HasColumnName("des_estudios")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("direccion")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasColumnName("distrito")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialistId).HasColumnName("especialista_idespe");

                entity.Property(e => e.Status).HasColumnName("estado");

                entity.Property(e => e.Birthday)
                    .HasColumnName("fecha_nacimiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudyLevel).HasColumnName("nivel_estudios");

                entity.Property(e => e.FirstName)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasColumnName("num_doc_identidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ocupation)
                    .HasColumnName("ocupacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("provincia")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mobilephone).HasColumnName("telefono");

                entity.Property(e => e.DocType)
                    .HasColumnName("tipo_documentacion")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TutorId).HasColumnName("tutor_idtutor");

                entity.HasOne(d => d.Specialist)
                    .WithMany(p => p.Pacients)
                    .HasForeignKey(d => d.SpecialistId)
                    .HasConstraintName("paciente_especialista_fk");

                entity.HasOne(d => d.Tutor)
                    .WithMany(p => p.Pacients)
                    .HasForeignKey(d => d.TutorId)
                    .HasConstraintName("paciente_tutor_fk");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasKey(e => e.TestId)
                    .HasName("test_pk");

                entity.ToTable("test");

                entity.Property(e => e.TestId).HasColumnName("idtest");

                entity.Property(e => e.DateTime)
                    .HasColumnName("fecha_hora")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasColumnName("nombre_test")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PacientId).HasColumnName("paciente_idpaciente");

                entity.Property(e => e.IsDone).HasColumnName("realizado");

                entity.Property(e => e.Result)
                    .HasColumnName("resultado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pacient)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.PacientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("test_paciente_fk");
            });

            modelBuilder.Entity<Tutor>(entity =>
            {
                entity.HasKey(e => e.TutorId)
                    .HasName("tutor_pk");

                entity.ToTable("tutor");

                entity.Property(e => e.TutorId).HasColumnName("idtutor");

                entity.Property(e => e.LastName)
                    .HasColumnName("apellidos")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("contrasenia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("correo")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDescription)
                    .HasColumnName("des_estado")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("estado");

                entity.Property(e => e.Birthday)
                    .HasColumnName("fecha_nacimiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasColumnName("num_doc_identidad")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Relation)
                    .HasColumnName("relacion")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Mobilephone).HasColumnName("telefono");

                entity.Property(e => e.DocType)
                    .HasColumnName("tipo_documentacion")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });
        }
    }
}
