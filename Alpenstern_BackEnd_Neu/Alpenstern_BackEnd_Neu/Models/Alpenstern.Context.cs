﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alpenstern_BackEnd_Neu.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class alpensternEntities : DbContext
    {
        public alpensternEntities()
            : base("name=alpensternEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Anfrage> Anfrage { get; set; }
        public virtual DbSet<Ausstattung> Ausstattung { get; set; }
        public virtual DbSet<Bilder> Bilder { get; set; }
        public virtual DbSet<Dinner> Dinner { get; set; }
        public virtual DbSet<Extras> Extras { get; set; }
        public virtual DbSet<Gaestebuch> Gaestebuch { get; set; }
        public virtual DbSet<Gast> Gast { get; set; }
        public virtual DbSet<Gastlogin> Gastlogin { get; set; }
        public virtual DbSet<Kategorie> Kategorie { get; set; }
        public virtual DbSet<Kategorieanfrage> Kategorieanfrage { get; set; }
        public virtual DbSet<Kategorieausstattung> Kategorieausstattung { get; set; }
        public virtual DbSet<Komplettbuchung> Komplettbuchung { get; set; }
        public virtual DbSet<Komplettpaket> Komplettpaket { get; set; }
        public virtual DbSet<Land> Land { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Mitarbeiter> Mitarbeiter { get; set; }
        public virtual DbSet<Rechnung> Rechnung { get; set; }
        public virtual DbSet<Rueckruf> Rueckruf { get; set; }
        public virtual DbSet<Saison> Saison { get; set; }
        public virtual DbSet<Spa> Spa { get; set; }
        public virtual DbSet<Stadt> Stadt { get; set; }
        public virtual DbSet<Zimmer> Zimmer { get; set; }
        public virtual DbSet<Zimmerbuchung> Zimmerbuchung { get; set; }
    
        [DbFunction("alpensternEntities", "get_user_salt")]
        public virtual IQueryable<get_user_salt_Result> get_user_salt(string benutzername)
        {
            var benutzernameParameter = benutzername != null ?
                new ObjectParameter("benutzername", benutzername) :
                new ObjectParameter("benutzername", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<get_user_salt_Result>("[alpensternEntities].[get_user_salt](@benutzername)", benutzernameParameter);
        }
    
        [DbFunction("alpensternEntities", "login_user")]
        public virtual IQueryable<login_user_Result> login_user(string benutzername, string passwort)
        {
            var benutzernameParameter = benutzername != null ?
                new ObjectParameter("benutzername", benutzername) :
                new ObjectParameter("benutzername", typeof(string));
    
            var passwortParameter = passwort != null ?
                new ObjectParameter("passwort", passwort) :
                new ObjectParameter("passwort", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<login_user_Result>("[alpensternEntities].[login_user](@benutzername, @passwort)", benutzernameParameter, passwortParameter);
        }
    
        [DbFunction("alpensternEntities", "uf_GastAnfrageDetails")]
        public virtual IQueryable<uf_GastAnfrageDetails_Result> uf_GastAnfrageDetails(Nullable<int> gastid, Nullable<int> anfrageid)
        {
            var gastidParameter = gastid.HasValue ?
                new ObjectParameter("gastid", gastid) :
                new ObjectParameter("gastid", typeof(int));
    
            var anfrageidParameter = anfrageid.HasValue ?
                new ObjectParameter("anfrageid", anfrageid) :
                new ObjectParameter("anfrageid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<uf_GastAnfrageDetails_Result>("[alpensternEntities].[uf_GastAnfrageDetails](@gastid, @anfrageid)", gastidParameter, anfrageidParameter);
        }
    
        public virtual int register_user(string benutzername, string passwort, string salt)
        {
            var benutzernameParameter = benutzername != null ?
                new ObjectParameter("benutzername", benutzername) :
                new ObjectParameter("benutzername", typeof(string));
    
            var passwortParameter = passwort != null ?
                new ObjectParameter("passwort", passwort) :
                new ObjectParameter("passwort", typeof(string));
    
            var saltParameter = salt != null ?
                new ObjectParameter("salt", salt) :
                new ObjectParameter("salt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("register_user", benutzernameParameter, passwortParameter, saltParameter);
        }
    
        public virtual ObjectResult<usp_datenabfragen_Result> usp_datenabfragen(Nullable<int> gastId)
        {
            var gastIdParameter = gastId.HasValue ?
                new ObjectParameter("GastId", gastId) :
                new ObjectParameter("GastId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_datenabfragen_Result>("usp_datenabfragen", gastIdParameter);
        }
    
        public virtual ObjectResult<usp_ZimmerAuslesen_Result> usp_ZimmerAuslesen()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ZimmerAuslesen_Result>("usp_ZimmerAuslesen");
        }
    }
}
