using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.ViewModels.Documents
{
    public class ScriptDocumentViewModel : DocumentViewModel
    {
        public ScriptDocumentViewModel(string path) : base(path)
        {

        }

        public override void OnSave(object parameter) => throw new NotImplementedException();

        public override Task<bool> OpenFileAsync(string path) => throw new NotImplementedException();
    }
}
