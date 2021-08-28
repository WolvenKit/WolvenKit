using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Documents
{
    public class TweakDocumentViewModel : DocumentViewModel
    {
        public TweakDocumentViewModel(string path) : base(path)
        {

        }

        #region properties



        #endregion


        public override void OnSave(object parameter)
        {

        }

        public override async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            //await using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                //using var reader = new BinaryReader(stream);



                ContentId = path;
                FilePath = path;
                IsDirty = false;
                Title = FileName;
                _isInitialized = true;

                return await Task.FromResult<bool>(true);
            }
        }
    }
}
