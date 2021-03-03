using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using WolvenKit.Common;
using WolvenKit.Radish.Model;

namespace WolvenKit.Functionality.Controllers
{
    public class RadishConfiguration : ObservableObject
    {
        #region Fields

        //
        private string _oldmodname;

        #endregion Fields

        #region Constructors

        public RadishConfiguration()
        {
        }

        #endregion Constructors



        #region Properties

        public static string ConfigurationPath
        {
            get
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir ?? "", filename + "_radishconfig.xml");
            }
        }

        [Browsable(false)]
        public string RadishProjectPath { get; set; }

        [Browsable(false)]
        public List<RadishWorkflow> Workflows { get; set; } = new List<RadishWorkflow>();

        #endregion Properties



        #region Methods

        public static RadishConfiguration Load()
        {
            if (File.Exists(ConfigurationPath) && new FileInfo(ConfigurationPath).Length != 0)
            {
                var ser = new XmlSerializer(typeof(RadishConfiguration));
                var stream = new FileStream(ConfigurationPath, FileMode.Open, FileAccess.Read);
                var config = (RadishConfiguration)ser.Deserialize(stream);
                stream.Close();
                return config;
            }

            // Defaults
            return new RadishConfiguration
            {
            };
        }

        public string GetOldModname() => _oldmodname;

        #endregion Methods

        #region modname

        private string _modname;

        public string modname
        {
            get => _modname;
            set
            {
                if (_modname != value)
                {
                    _oldmodname = _modname;
                    _modname = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion modname

        #region idspace

        private string _idspace;

        public string idspace
        {
            get => _idspace;
            set
            {
                if (_idspace != value)
                {
                    _idspace = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion idspace

        #region DIR_ENCODER

        private string _DIR_ENCODER;

        public string DIR_ENCODER
        {
            get => _DIR_ENCODER;
            set
            {
                if (_DIR_ENCODER != value)
                {
                    _DIR_ENCODER = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion DIR_ENCODER

        #region DIR_MODKIT

        private string _DIR_MODKIT;

        public string DIR_MODKIT
        {
            get => _DIR_MODKIT;
            set
            {
                if (_DIR_MODKIT != value)
                {
                    _DIR_MODKIT = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion DIR_MODKIT

        #region DIR_W3

        private string _DIR_W3;

        public string DIR_W3
        {
            get => _DIR_W3;
            set
            {
                if (_DIR_W3 != value)
                {
                    _DIR_W3 = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion DIR_W3

        public void Save()
        {
            var ser = new XmlSerializer(typeof(RadishConfiguration));
            var stream = new FileStream(RadishConfiguration.ConfigurationPath, FileMode.Create, FileAccess.Write);
            ser.Serialize(stream, this);
            stream.Close();
        }
    }
}
