using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Wcc;

namespace WolvenKit.Model
{
    public class XBMDumpRecord
    {
        public string RedName { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Format { get; set; }
        public string Compression { get; set; }
        public string TextureGroup { get; set; }

    }

    public class ImportableFile : ObservableObject
    {
        public enum EObjectState
        {
            NoTextureGroup, //Orange
            Ready,  //Green
            Error //Read
        }

        #region IsSelected
        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Texturegroup
        private ETextureGroup _textureGroup;
        public ETextureGroup TextureGroup
        {
            get => _textureGroup;
            set
            {
                if (_textureGroup != value)
                {
                    _textureGroup = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region ImportType

        public Enum ImportType { get; }

        #endregion

        /// <summary>
        /// PropertyBound in the listView
        /// </summary>
        public string Name => Path.GetFileName(GetRelativePath());
        private readonly string _relativePath;
        
        private readonly EImportable _type;
        private EObjectState _state;

        public string GetRelativePath() => _relativePath;

        public (string, bool) GetREDRelativePath()
        {
            var relPath = this.GetRelativePath();

            // make new path
            // first, trim Raw from the path
            if (relPath.Substring(0, 3) == "Raw")
                relPath = relPath.Substring(4);
            // then, trim Mod or dlc from the path
            bool isDLC = false;
            if (relPath.Substring(0, 3) == "Mod")
            {
                relPath = relPath.Substring(4);
            }
            if (relPath.Substring(0, 3) == "DLC")
            {
                isDLC = true;
                relPath = relPath.Substring(4);
            }

            // new path with new extension
            string importext = $".{this.ImportType:G}";
            relPath = Path.ChangeExtension(relPath, importext);

            return (relPath, isDLC);
        }

        public EImportable GetImportableType() => _type;
        public EObjectState GetState() => _state;
        public void SetState(EObjectState value)
        {
            if (_state != value)
            {
                _state = value;
                OnPropertyChanged();
            }
        }

        public ImportableFile(string path, EImportable type, Enum importtype)
        {
            _relativePath = path;
            _type = type;
            ImportType = importtype;
        }

        

    }
}
