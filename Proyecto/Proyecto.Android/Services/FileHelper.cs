using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Proyecto.iOS.Services;
using Proyecto.Services;
using UIKit;
using Xamarin.Forms;



namespace Proyecto.Droid.Services
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}