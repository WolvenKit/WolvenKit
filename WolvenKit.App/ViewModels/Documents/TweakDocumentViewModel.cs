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

        [Reactive] public string DocumentSource {  get; set; }  

        #endregion


        public override void OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new StreamWriter(fs);
           bw.Write(DocumentSource);
        }

        public override async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            await using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var sr = new StreamReader(fs))
                {
                    DocumentSource = sr.ReadToEnd();
                }

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
