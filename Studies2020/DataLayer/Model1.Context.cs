﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Studies2020.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StudijeEntities : DbContext
    {
        public StudijeEntities()
            : base("name=StudijeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ispit> Ispits { get; set; }
        public virtual DbSet<IspitniRok> IspitniRoks { get; set; }
        public virtual DbSet<Predmet> Predmets { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentIspit> StudentIspits { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int PredmetDelete(Nullable<int> idPredmet)
        {
            var idPredmetParameter = idPredmet.HasValue ?
                new ObjectParameter("idPredmet", idPredmet) :
                new ObjectParameter("idPredmet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PredmetDelete", idPredmetParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int StudentDelete(Nullable<int> idStudent)
        {
            var idStudentParameter = idStudent.HasValue ?
                new ObjectParameter("idStudent", idStudent) :
                new ObjectParameter("idStudent", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StudentDelete", idStudentParameter);
        }
    
        public virtual int StudentInsert(string ime, string prezime, Nullable<int> indeksBroj, Nullable<int> indeksGodina, ObjectParameter idStudent)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("ime", ime) :
                new ObjectParameter("ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("prezime", prezime) :
                new ObjectParameter("prezime", typeof(string));
    
            var indeksBrojParameter = indeksBroj.HasValue ?
                new ObjectParameter("indeksBroj", indeksBroj) :
                new ObjectParameter("indeksBroj", typeof(int));
    
            var indeksGodinaParameter = indeksGodina.HasValue ?
                new ObjectParameter("indeksGodina", indeksGodina) :
                new ObjectParameter("indeksGodina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StudentInsert", imeParameter, prezimeParameter, indeksBrojParameter, indeksGodinaParameter, idStudent);
        }
    
        public virtual int StudentUpdate(Nullable<int> idStudent, string ime, string prezime, Nullable<int> indeksBroj, Nullable<int> indeksGodina, Nullable<int> idKorisnik, ObjectParameter error)
        {
            var idStudentParameter = idStudent.HasValue ?
                new ObjectParameter("idStudent", idStudent) :
                new ObjectParameter("idStudent", typeof(int));
    
            var imeParameter = ime != null ?
                new ObjectParameter("ime", ime) :
                new ObjectParameter("ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("prezime", prezime) :
                new ObjectParameter("prezime", typeof(string));
    
            var indeksBrojParameter = indeksBroj.HasValue ?
                new ObjectParameter("indeksBroj", indeksBroj) :
                new ObjectParameter("indeksBroj", typeof(int));
    
            var indeksGodinaParameter = indeksGodina.HasValue ?
                new ObjectParameter("indeksGodina", indeksGodina) :
                new ObjectParameter("indeksGodina", typeof(int));
    
            var idKorisnikParameter = idKorisnik.HasValue ?
                new ObjectParameter("idKorisnik", idKorisnik) :
                new ObjectParameter("idKorisnik", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StudentUpdate", idStudentParameter, imeParameter, prezimeParameter, indeksBrojParameter, indeksGodinaParameter, idKorisnikParameter, error);
        }
    }
}
