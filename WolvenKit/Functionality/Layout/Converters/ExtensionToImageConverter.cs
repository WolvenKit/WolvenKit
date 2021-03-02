using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Catel.MVVM.Converters;
using WolvenKit.Common;
using WolvenKit.Model;

namespace WolvenKit.Functionality.Layout.Converters
{
    public class ExtensionToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;

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
            extension = extension.TrimStart('.').Trim();
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

                case nameof(ECustomImageKeys.ClosedDirImageKey):
                    return $"Files/FolderClosed_16x.png";
                case nameof(ECustomImageKeys.OpenDirImageKey):
                    return $"Files/FolderOpened_16x.png";

                case nameof(ECustomImageKeys.RawImageKey):
                case nameof(ECustomImageKeys.RawModImageKey): 
                case nameof(ECustomImageKeys.RawDlcImageKey): 
                case nameof(ECustomImageKeys.RadishImageKey):
                case nameof(ECustomImageKeys.ModImageKey): 
                case nameof(ECustomImageKeys.ModCookedImageKey): 
                case nameof(ECustomImageKeys.ModUncookedImageKey): 
                case nameof(ECustomImageKeys.DlcImageKey): 
                case nameof(ECustomImageKeys.DlcCookedImageKey): 
                case nameof(ECustomImageKeys.DlcUncookedImageKey):
                    return $"Files/Project_Explorer_Base_Dir_16x.png";

                default: return $"Files/BlankFile_16x.png";
            }
        }
    }
}
