using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using TECHWIZ.Models;

namespace TECHWIZ.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomUser> CustomUsers { get; set; }  

        public virtual DbSet<MedicalCategory> MedicalCategories { get; set; }
        public virtual DbSet<MedicalDetail> MedicalDetails { get; set; }

        public virtual DbSet<Prescription> Prescriptions { get; set; }

        public virtual DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }




    }
}