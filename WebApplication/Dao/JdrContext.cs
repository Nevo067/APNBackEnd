using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using MySQL.Data.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using WebApplication.Model;

namespace WebApplication.Dao
{
    public class JdrContext:DbContext
    {
        public DbSet<Jdr>JdrTable{get;set;}
        public DbSet<Membre>MembreTable { get; set; }
        public DbSet<Objet>ObjetTable { get; set; }
        
        public DbSet<Chara>Charactere { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            //base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.UseMySQL("Server=localhost;port=3306;Database=dialogue;Uid=root;Pwd=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Objet>()
                .Property(S => S.val)
                .HasDefaultValue("1d1");
            modelBuilder.Entity<Objet>().HasKey(s => s.ObjetId);
            modelBuilder.Entity<Objet>()
                .HasOne<Chara>(s => s.chara)
                .WithMany(s => s.objet)
                .HasForeignKey(t => t.CharaId);
            //Many to many JdrMembre
            modelBuilder.Entity<JdrMembre>()
                .HasOne<Membre>(s => s.membres)
                .WithMany(t => t.ListMembre)
                .HasForeignKey(x => x.MembreId);

            modelBuilder.Entity<JdrMembre>()
                .HasOne<Jdr>(x => x.jdrs)
                .WithMany(x => x.jdrMembresList)
                .HasForeignKey(x => x.MembreId);
            //Many to One  Membre to Chara
            modelBuilder.Entity<Chara>()
                .HasOne<Membre>(x => x.mb)
                .WithMany(x => x.ListCharas)
                .HasForeignKey(x => x.MembreId);
            //MANY to One Chara to jdr
            modelBuilder.Entity<Chara>()
                .HasOne<Jdr>(x => x.jdr)
                .WithMany(x => x.jdrsList)
                .HasForeignKey(x => x.JdrId);

        }

        public void ApplyOptionChange()
        {
            List<string>nomTable = new List<string>();
            MySqlConnection connection = Databases.Databases.GetConnetion();
            connection.Open();
            MySqlCommand command=connection.CreateCommand();
            command.CommandText = "SELECT `TABLE_NAME`FROM `INFORMATION_SCHEMA`.`TABLES` WHERE `TABLE_SCHEMA` = SCHEMA() ;";
            
            using (MySqlDataReader dataReader=command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader.GetString("TABLE_NAME"));
                    nomTable.Add(dataReader.GetString("TABLE_NAME"));
                }
            }
            foreach (string nom in nomTable)
            {
                MySqlConnection connect  = Databases.Databases.GetConnetion();
                connect.Open();
                command = connect.CreateCommand();
                command.CommandText =$"ALTER TABLE {nom} ENGINE = InnoDB";
                command.ExecuteNonQuery();
            }
        }
       
    }
}