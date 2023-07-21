using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Domain
{
	public class EFApplication
	{
		private DiplomdbContext db;
		public EFApplication(DiplomdbContext db)
		{
			this.db = db;
		}
		public IQueryable<Application> GetApplications()
		{

			return db.Applications;
		}
		public Application GetApplicationByStart(DateTime Name)
		{
			//var res = stationDBEntities.Employees.FromSqlRaw($"select * from Employee where Name='{Name}'").ToList();
			//if (res.IsNullOrEmpty())
			//	return null;
			//return res.ElementAt(0);
			return db.Applications.FirstOrDefault(x => x.DateTimeStart == Name);
		}
        public IQueryable<Application> GetApplicationByUserId(int Name)
        {
            //var res = stationDBEntities.Employees.FromSqlRaw($"select * from Employee where Name='{Name}'").ToList();
            //if (res.IsNullOrEmpty())
            //	return null;
            //return res.ElementAt(0);
            return db.Applications.Where(x=>x.UserId==Name);
        }
        public Application GetApplicationById(int id)
		{
			return db.Applications.FirstOrDefault(x=>x.Id==id);
        }
		public void SaveApplication(Application item)
		{
			if(item.Id==default)
			{
				db.Applications.Add(item);
			}
			else
			{
				db.Applications.Where(x => x.Id == item.Id).ExecuteUpdate(i => i.SetProperty(x => x.DateTimeStart, item.DateTimeStart).SetProperty(x => x.Opis, item.Opis)
				.SetProperty(x => x.DateTimeEnd, item.DateTimeEnd).SetProperty(x => x.Prim, item.Prim)
				.SetProperty(x => x.CompName, item.CompName).SetProperty(x => x.Tel, item.Tel)
				.SetProperty(x => x.AppState, item.AppState));
			}
			db.SaveChanges();
		}
		public void DeleteApplication(Application name)
		{
			var item = db.Applications.FirstOrDefault(x => x.Id == name.Id);
			if (item != null)
			{
				db.Applications.Remove(name);
				db.SaveChanges();
			}
		}
	}
}
