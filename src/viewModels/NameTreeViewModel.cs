using Anem.NAME.Models;
using DevExpress.Mvvm.POCO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Anem.NAME.ViewModels
{

    public class NameTreeViewModel
    {


        #region attributes
        #endregion

        #region properties and services

        public virtual Version Version { get; set; }
        public virtual IList<NameObject> Nodes { get; set; }
        public virtual IList<FicheNameDetails> NameDetails { get; set; }
        public virtual FicheNameDetails SelectedName { get; set; }



        #endregion


        #region constructor

        public NameTreeViewModel()
        {
            Version = Assembly.GetExecutingAssembly().GetName().Version;

            var nameDetailsPath = Path.Combine(Directory.GetCurrentDirectory(), "data","name_details.json");

            if (File.Exists(nameDetailsPath) == false) throw new FileNotFoundException(nameDetailsPath);
            var nameDetailsText = File.ReadAllText(nameDetailsPath);
            NameDetails = JsonConvert.DeserializeObject<List<FicheNameDetails>>(nameDetailsText);


            var path = Path.Combine(Directory.GetCurrentDirectory(), "data\\name.json");
            var text = File.ReadAllText(path);
            Nodes = JsonConvert.DeserializeObject<List<NameObject>>(text);
        }

        public static NameTreeViewModel Create()
        {
            return ViewModelSource.Create(() => new NameTreeViewModel());
        }
        #endregion


        #region methods and commands

        public void DisplayName(NameObject o)
        {
            if (o.Level != 4) return;

            //find the corresponding name

            SelectedName = NameDetails.FirstOrDefault(n => n.Intitule == o.Intitule);
        }

        #endregion


    }
}
