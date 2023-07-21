using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Domain
{
	public class EFAdmin
	{
		private DiplomdbContext db;
		public EFAdmin(DiplomdbContext db)
		{
			this.db = db;
		}
		public IQueryable<Admin> GetAdmins()
		{

			return db.Admins;
		}
		public Admin GetAdminByName(string Name)
		{
			
			return db.Admins.FirstOrDefault(x => x.Login == Name);
		}

		public Admin GetAdminById(int id)
		{
			return db.Admins.FirstOrDefault(x=>x.Id==id);
        }
		public void SaveAdmin(Admin item)
		{
			if(item.Id==default)
			{
				db.Admins.Add(item);
			}
			else
			{
                db.Admins.Where(x => x.Id == item.Id).ExecuteUpdate(i => i.SetProperty(x => x.Fio, item.Fio).SetProperty(x => x.Login, item.Login)
                .SetProperty(x => x.Password, item.Password).SetProperty(x => x.ByroId, item.ByroId));
            }
			db.SaveChanges();
		}
		public void DeleteAdmin(Admin name)
		{
			var item = db.Admins.FirstOrDefault(x => x.Id == name.Id);
			if (item != null)
			{
				db.Admins.Remove(name);
				db.SaveChanges();
			}
		}
	}
}
