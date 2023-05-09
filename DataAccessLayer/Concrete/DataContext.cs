using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class DataContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=SEDO; database=Stajtakip; integrated security=true; TrustServerCertificate=True;");
		}

		public DbSet<Kullanici> kullanicis { get; set; }
		public DbSet<StajBilgi> stajBilgis { get; set; }
	}
}
