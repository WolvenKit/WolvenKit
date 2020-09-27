using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Wcc;

namespace WolvenKit.App.Model
{
    public class XBMDump
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

        public string Name => Path.GetFileName(GetRelativePath());

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


        private readonly string _relativePath;
        
        private readonly EImportable _type;
        private EObjectState _state;

        public string GetRelativePath() => _relativePath;
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
