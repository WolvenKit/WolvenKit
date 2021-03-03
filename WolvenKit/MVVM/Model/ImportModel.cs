using System;
using System.IO;
using WolvenKit.Common;
using WolvenKit.Common.Wcc;

namespace WolvenKit.MVVM.Model
{
    public class ImportableFile : ObservableObject
    {
        #region Fields

        private readonly string _relativePath;

        private readonly EImportable _type;

        private EObjectState _state;

        #endregion Fields

        #region Constructors

        public ImportableFile(string path, EImportable type, Enum importtype)
        {
            _relativePath = path;
            _type = type;
            ImportType = importtype;
        }

        #endregion Constructors



        #region Enums

        public enum EObjectState
        {
            NoTextureGroup, //Orange
            Ready,  //Green
            Error //Read
        }

        #endregion Enums

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

        #endregion IsSelected

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

        #endregion Texturegroup

        #region ImportType

        public Enum ImportType { get; }

        #endregion ImportType



        #region Properties

        /// <summary>
        /// PropertyBound in the listView
        /// </summary>
        public string Name => Path.GetFileName(GetRelativePath());

        #endregion Properties



        #region Methods

        public EImportable GetImportableType() => _type;

        public (string, bool) GetREDRelativePath()
        {
            var relPath = this.GetRelativePath();

            // make new path
            // first, trim Raw from the path
            if (relPath.Substring(0, 3) == "Raw")
            {
                relPath = relPath.Substring(4);
            }
            // then, trim Mod or dlc from the path
            var isDLC = false;
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
            var importext = $".{this.ImportType:G}";
            relPath = Path.ChangeExtension(relPath, importext);

            return (relPath, isDLC);
        }

        public string GetRelativePath() => _relativePath;

        public EObjectState GetState() => _state;

        public void SetState(EObjectState value)
        {
            if (_state != value)
            {
                _state = value;
                OnPropertyChanged();
            }
        }

        #endregion Methods
    }

    public class XBMDumpRecord
    {
        #region Properties

        public string Compression { get; set; }
        public string Format { get; set; }
        public string Height { get; set; }
        public string RedName { get; set; }
        public string TextureGroup { get; set; }
        public string Width { get; set; }

        #endregion Properties
    }
}
