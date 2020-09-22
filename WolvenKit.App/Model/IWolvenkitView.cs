using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.App.ViewModels;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// A CR2W Form
    /// </summary>
    public interface IWolvenkitView
    {
        string FileName { get; }

        IDocumentViewModel GetViewModel();

        void Close();
        void Activate();
    }
}
