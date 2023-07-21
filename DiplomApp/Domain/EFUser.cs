using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Domain
{
	public class EFUser
	{
		private DiplomdbContext db;
		public EFUser(DiplomdbContext db)
		{
			this.db = db;
		}
		public IQueryable<User> GetUsers()
		{

			return db.Users;
		}
		public User GetUserByName(string Name)
		{
			//var res = stationDBEntities.Employees.FromSqlRaw($"select * from Employee where Name='{Name}'").ToList();
			//if (res.IsNullOrEmpty())
			//	return null;
			//return res.ElementAt(0);
			return db.Users.FirstOrDefault(x => x.Login == Name);
		}
        public User GetUserByFio(string Name)
        {
            //var res = stationDBEntities.Employees.FromSqlRaw($"select * from Employee where Name='{Name}'").ToList();
            //if (res.IsNullOrEmpty())
            //	return null;
            //return res.ElementAt(0);
            return db.Users.FirstOrDefault(x => x.Fio == Name);
        }
        public User GetUserById(int id)
		{
			return db.Users.FirstOrDefault(x=>x.Id==id);
        }
		public void SaveUser(User item)
		{
			if(item.Id==default)
			{
				db.Users.Add(item);
			}
			else
			{
				var old = GetUserById(item.Id);
				old = item;
			}
			db.SaveChanges();
		}
		public void DeleteUser(User name)
		{
			var item = db.Users.FirstOrDefault(x => x.Id == name.Id);
			if (item != null)
			{
				db.Users.Remove(name);
				db.SaveChanges();
			}
		}
	}
}
