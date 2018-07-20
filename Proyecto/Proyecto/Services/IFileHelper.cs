using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Services
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
