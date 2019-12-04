namespace Pidev.data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Pidev.Domain.Entities;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

      //  public virtual DbSet<C__migrationhistory> C__migrationhistory { get; set; }
        public virtual DbSet<commentaire> commentaire { get; set; }
        public virtual DbSet<contrat> contrat { get; set; }
        public virtual DbSet<publication> publication { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<map> map { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<C__migrationhistory>()
            //    .Property(e => e.MigrationId)
            //    .IsUnicode(false);

            //modelBuilder.Entity<C__migrationhistory>()
            //    .Property(e => e.ContextKey)
            //    .IsUnicode(false);

            //modelBuilder.Entity<C__migrationhistory>()
            //    .Property(e => e.ProductVersion)
            //    .IsUnicode(false);

            modelBuilder.Entity<commentaire>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<contrat>()
                .Property(e => e.dateDebutC)
                .IsUnicode(false);

            modelBuilder.Entity<contrat>()
                .Property(e => e.dateFinC)
                .IsUnicode(false);

            modelBuilder.Entity<contrat>()
                .HasMany(e => e.user)
                .WithOptional(e => e.contrat)
                .HasForeignKey(e => e.contrat_id);

            modelBuilder.Entity<publication>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<publication>()
                .HasMany(e => e.commentaire)
                .WithOptional(e => e.publication)
                .HasForeignKey(e => e.id_pub);

            modelBuilder.Entity<user>()
                .Property(e => e.addresse)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.cin)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.commentaire)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.id_user);

            modelBuilder.Entity<user>()
                .HasMany(e => e.contrat1)
                .WithOptional(e => e.user1)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.publication)
                .WithOptional(e => e.user1)
                .HasForeignKey(e => e.user);
        }
    }
}
