using DevExpress.Mvvm.POCO;
using System;
using System.Reflection;

namespace Anem.NAME.ViewModels
{
    public class AboutViewModel
    {


        #region attributes
        #endregion

        #region properties and services

        public virtual Version Version { get; set; }

        #endregion


        #region constructor

        public AboutViewModel()
        {
            Version = Assembly.GetExecutingAssembly().GetName().Version;

            //MyDbContext db = new MyDbContext();
            //db.Nodes.Add(new Node { Id = Guid.NewGuid().ToString(), Intitule = "sdfsqf", Level = 1 });
            //db.SaveChanges();
        }

        public static AboutViewModel Create()
        {
            return ViewModelSource.Create(() => new AboutViewModel());
        }
        #endregion


        #region methods and commands

        #endregion


    }
}
