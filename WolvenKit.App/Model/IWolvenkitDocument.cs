using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.App.ViewModels;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// A CR2W document
    /// </summary>
    public interface IWolvenkitDocument
    {

        string Cr2wFileName { get; }
        //object SaveTarget { get; set; }


        //void SaveFile();
        void Close();

        bool GetIsDisposed();

        DocumentViewModel GetViewModel();
    }
}
