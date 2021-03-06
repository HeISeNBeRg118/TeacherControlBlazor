﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TeacherControl.Models;

namespace TeacherControl.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Nacionalidades> Nacionalidades { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Adicionales> Adicionales { get; set; }
        public DbSet<TiposTelefonos> TiposTelefonos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\TeacherControl.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nacionalidades>().HasData(new Nacionalidades { 
                NacionalidadId=1,
                Nacionalidad="Dominicana"});

            modelBuilder.Entity<TiposTelefonos>().HasData(new TiposTelefonos
            {
                TipoId = 1,
                Descripcion = "Casa"
            });

            modelBuilder.Entity<TiposTelefonos>().HasData(new TiposTelefonos
            {
                TipoId = 2,
                Descripcion = "Celular"
            });
        }

     
    }
}
