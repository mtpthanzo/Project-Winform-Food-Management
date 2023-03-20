using ProjectLibrary.DataAccess;
using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Repository
{
    public class MenuRepository : IMenuReporitory
    {
        public void InsertMenu(MenuObject menuObject) => MenuDBContext.Instance.AddNew(menuObject);

        public void Delete(int foodID) => MenuDBContext.Instance.Remove(foodID);

        public MenuObject GetMenuByID(int foodID) => MenuDBContext.Instance.GetMenuByID(foodID);

        public IEnumerable<MenuObject> GetMenus() => MenuDBContext.Instance.GetListMenu();

        public void UpdateMenu(MenuObject menuObject) => MenuDBContext.Instance.Update(menuObject);
    }
}
