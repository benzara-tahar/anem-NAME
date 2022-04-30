using Anem.NAME.views;
using DevExpress.Mvvm.POCO;
using System;

namespace Anem.NAME.ViewModels
{
    public class ShellViewModel
    {
        #region attributes
        #endregion

        #region properties and services

        public virtual object Content { get; set; }

        #endregion



        #region constructor

        public ShellViewModel()
        {
            //todo: remove reference view
            Content = new PresentationView();
        }

        public static ShellViewModel Create()
        {
            return ViewModelSource.Create(() => new ShellViewModel());
        }
        #endregion


        #region methods and commands

        public virtual void SetView(Type type)
        {
            Content = Activator.CreateInstance(type);
        }

        #endregion


    }
}
