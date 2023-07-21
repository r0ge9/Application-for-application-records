using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DiplomApp.Domain
{
    public class DataManager
    {
       public DiplomdbContext db;
        public EFAdmin admins;
        public EFApplication applications;
        public EFUser users;
        public DataManager()
        {
            db=new DiplomdbContext();
            admins = new EFAdmin(db);
            applications= new EFApplication(db);
            users=new EFUser(db);
        }
    }
}
