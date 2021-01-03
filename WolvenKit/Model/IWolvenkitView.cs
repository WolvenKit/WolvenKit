using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.ViewModels;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// A CR2W Form
    /// </summary>
    public interface IWolvenkitView
    {
        string FileName { get; }

        Old_IDocumentViewModel GetViewModel();

        void Close();
        void Activate();
    }
}
