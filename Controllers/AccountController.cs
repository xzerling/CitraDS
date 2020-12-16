using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitraDataStore.Models;
using System.Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Reflection;
using System.Text;


namespace CitraDataStore.Controllers
{
    public class AccountController : Controller
    {
        readonly MyDbContext db = new MyDbContext();

        public IActionResult Login()
        {
            return View();
        }

        public ActionResult Validate(Admins admin)
        {
            var _admin = db.Admins.Where(s => s.Email == admin.Email).FirstOrDefault();

            if (_admin != null)
            {
                if (_admin.Password == admin.Password)
                {
                    //HttpContext.Session.SetString("email", _admin.Email);
                    try
                    {
                        HttpContext.Session.SetString("email", admin.Email);
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                    HttpContext.Session.SetInt32("id", _admin.Id);
                    HttpContext.Session.SetInt32("role_id", (int)_admin.RolesId);
                    HttpContext.Session.SetString("name", _admin.FullName);
                    HttpContext.Session.SetString("id_estaciones_asignadas", _admin.IdEstacionesAsignadas);
                    HttpContext.Session.SetInt32("dias_disponibles", _admin.Dias_disponibles);
                    int roleId = (int)HttpContext.Session.GetInt32("role_id");
                    List<Menus> menus = db.LinkRolesMenus.Where(s => s.RolesId == roleId).Select(s => s.Menus).ToList();

                    DataSet ds = new DataSet();
                    ds = ToDataSet(menus);
                    DataTable table = ds.Tables[0];
                    DataRow[] parentMenus = table.Select("ParentId = 0");

                    var sb = new StringBuilder();
                    string menuString = GenerateUL(parentMenus, table, sb);
                    HttpContext.Session.SetString("menuString", menuString);
                    HttpContext.Session.SetString("menus", JsonConvert.SerializeObject(menus));

                    return Json(new { status = true, message = "Login Successfull!", context = HttpContext.Session.GetString("email"), context2 = _admin.FullName });
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }

        private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb)
        {
            if (menu.Length > 0)
            {
                foreach (DataRow dr in menu)
                {
                    string url = dr["Url"].ToString();
                    string menuText = dr["Name"].ToString();
                    string icon = dr["Icon"].ToString();

                    if (url != "#")
                    {
                        string line = String.Format(@"
                                    <a class=""collapse-item""href=""{0}"">
                                        <i class=""{2}""></i> 
                                            <span>{1}</span>
                                    </a>", url, menuText, icon);
                        sb.Append(line);
                    }

                    string pid = dr["Id"].ToString();
                    string parentId = dr["ParentId"].ToString();

                    DataRow[] subMenu = table.Select(String.Format("ParentId = '{0}'", pid));
                    if (subMenu.Length > 0 && !pid.Equals(parentId))
                    {
                        string preline = "";
                        string line = String.Format(@"
                                <li class=""nav-item"">
                                    <a class=""nav-link collapsed"" data-toggle=""collapse"" data-target=""#menu{2}"" href=""#"" aria-expanded=""true"" aria-controls=""menu{2}"">
                                        <i class=""{0}""></i> 
                                        <span>{1}</span>
                                    </a>
                                    <div id=""menu{2}"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                                    <div class=""bg-white py-2 collapse-inner rounded"">", icon, menuText, pid);
                        var subMenuBuilder = new StringBuilder();
                        sb.AppendLine(line);
                        sb.Append(GenerateUL(subMenu, table, subMenuBuilder));
                        sb.Append("</div></div></li>");
                    }
                }
            }
            return sb.ToString();
        }

        public DataSet ToDataSet<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dataTable);
            return ds;
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }

    }
}