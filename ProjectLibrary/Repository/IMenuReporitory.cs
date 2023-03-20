using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Repository
{
    public interface IMenuReporitory
    {
        IEnumerable<MenuObject>  GetMenus();

        MenuObject GetMenuByID(int foodID);
        void InsertMenu(MenuObject menuObject);
        void UpdateMenu(MenuObject menuObject);
        void Delete(int foodID);
    }
}
