using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Catel.MVVM.Converters;
using WolvenKit.Model;

namespace WolvenKit.Layout.Converters
{
    public class ExtensionToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            string extension = value.ToString();

            if (!string.IsNullOrEmpty(extension))
            {
                string result = GetSmallIconForFileType(extension);
                var uri = new Uri("pack://application:,,,/WolvenKit;component/Resources/Images/" + result);

                return uri;
            }

            return string.Empty;
        }

        // No need to implement converting back on a one-way binding
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }

        private static string GetSmallIconForFileType(string extension)
        {
            extension = extension.TrimStart('.');
            switch (extension)
            {
                case "w2ent":
                case "w2faces": 
                case "w2fnt": 
                case "w2je": 
                case "w2job":
                case "w2l":
                case "w2mg": 
                case "w2mi": 
                case "w2p": 
                case "w2phase": 
                case "w2quest": 
                case "w2rag": 
                case "w2ragdoll":
                case "w2rig": 
                case "w2scene": 
                case "w2steer": 
                case "w2w": 
                case "csv": 
                case "env": 
                case "journal": 
                case "redgame": 
                case "redswf": 
                case "spawntree": 
                case "swf": 
                case "vbrush":
                case "w2anim": 
                case "w2animev": 
                case "w2anims": 
                case "w2beh": 
                case "w2behtree":
                case "w2cent":
                case "w2comm":
                case "w2conv": 
                case "w2cube": 
                case "w2cutscene":
                    return $"RedEngine/{extension}.png";

                case "w2mesh":
                case "redcloth":
                case "xbm":
                case "fbx":
                case "xml":
                case "apb":
                case "blend":
                case "zip":
                    return $"Files/{extension}_32x.png";

                case "tga": 
                case "png": 
                case "dds":
                case "jpg": 
                case "jpeg":
                case "xcf":
                case "psd":
                    return $"Files/image_32x.png";

                case "apx": 
                case "ctw":
                    return $"Files/apb_32x.png";

                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.ClosedDirImageKey):
                    return $"Files/FolderClosed_16x.png";
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.OpenDirImageKey):
                    return $"Files/FolderOpened_16x.png";

                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.RawImageKey):
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.RawModImageKey): 
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.RawDlcImageKey): 
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.RadishImageKey):
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.ModImageKey): 
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.ModCookedImageKey): 
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.ModUncookedImageKey): 
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.DlcImageKey): 
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.DlcCookedImageKey): 
                case nameof(App.Model.FileSystemInfoModel.ECustomImageKeys.DlcUncookedImageKey):
                    return $"Files/Project_Explorer_Base_Dir_16x.png";

                default: return $"Files/BlankFile_32x.png";
            }
        }
    }
}
