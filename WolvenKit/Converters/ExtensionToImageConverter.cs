using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Data;
using WolvenKit.Common;

namespace WolvenKit.Converters
{
    public class ExtensionToImageConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return DependencyProperty.UnsetValue;
            }

            var extension = value.ToString();

            if (string.IsNullOrEmpty(extension))
            {
                return string.Empty;
            }

            var result = GetSmallIconForFileType(extension) ?? "Icons/Files/default.svg";

            // Trace.WriteLine("Resources/Media/Images/" + result);

            var uri = new Uri("pack://application:,,,/WolvenKit;component/Resources/Media/Images/" + result);
            //var svgDoc = SvgDocument.Open("pack://application:,,,/WolvenKit;component/Resources/Media/Images/" + result);
            //var Image = new Bitmap(svgDoc.Draw());

            return uri;

        }

        // No need to implement converting back on a one-way binding
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => DependencyProperty.UnsetValue;

        private static string GetSmallIconForFileType(string extension)
        {
            extension = extension.TrimStart('.').Trim();
            if (!Enum.IsDefined(typeof(ECustomImageKeys), extension))
            {
                extension = extension.ToLower();
            }

            switch (extension)
            {
                case nameof(ECustomImageKeys.OpenDirImageKey):
                    return $"Icons/Files/folderopened.svg";
                case nameof(ECustomImageKeys.ClosedDirImageKey):
                    return $"Icons/Files/folderdefault.svg";
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
                    return $"Icons/Files/folderclosed.svg";





                case "aiarch":
                case "animgraph":
                case "anims":
                case "apb":
                case "archetypes":
                case "areas":
                case "audio_metadata":
                case "audiovehcurveset":
                case "behavior":
                case "bikecurveset":
                case "bk2":
                case "blend":
                case "bnk":
                case "buffer":
                case "camcurveset":
                case "cfoliage":
                case "charcustpreset":
                case "cminimap":
                case "community":
                case "conversations":
                case "cooked_mlsetup":
                case "cookedanims":
                case "cookedapp":
                case "credits":
                case "cubemap":
                case "curveset":
                case "dat":
                case "devices":
                case "dtex":
                case "effect":
                case "envparam":
                case "envprobe":
                case "es":
                case "facialcustom":
                case "facialsetup":
                case "fb2tl":
                case "fbx":
                case "flyr":
                case "fnt":
                case "folbrush":
                case "foldest":
                case "font":
                case "formation":
                case "fp":
                case "gamedef":
                case "garmentlayerparams":
                case "genericanimdb":
                case "geometry_cache":
                case "grassmask":
                case "hitrepresentation":
                case "hp":
                case "ies":
                case "inkanim":
                case "inkatlas":
                case "inkcharcustomization":
                case "inkfontfamily":
                case "inkfullscreencomposition":
                case "inkgamesettings":
                case "inkhud":
                case "inklayers":
                case "inkmenu":
                case "inkshapecollection":
                case "inkstyle":
                case "inktypography":
                case "inkwidget":
                case "interaction":
                case "journal":
                case "journaldesc":
                case "json":
                case "lane_connections":
                case "lane_polygons":
                case "lane_spots":
                case "lights":
                case "location":
                case "locopaths":
                case "loot":
                case "mappins":
                case "menu":
                case "mesh":
                case "mi":
                case "morphtarget":
                case "mt":
                case "navconfig":
                case "naviobstacles":
                case "navmesh":
                case "navtile":
                case "null_areas":
                case "opuspak":
                case "particle":
                case "phys":
                case "physicalscene":
                case "physmatlib":
                case "poimappins":
                case "popup":
                case "psrep":
                case "quest":
                case "questphase":
                case "redapex":
                case "redcloth":
                case "reddlc":
                case "redexp":
                case "redfur":
                case "redgame":
                case "regionset":
                case "remt":
                case "reslist":
                case "rig":
                case "sav":
                case "scene":
                case "scenerid":
                case "scenesversions":
                case "w3simplex":
                case "smartobject":
                case "smartobjects":
                case "sp":
                case "spawntree":
                case "srt":
                case "streamingquerydata":
                case "streamingsector":
                case "streamingsector_inplace":
                case "streamingworld":
                case "subs":
                case "swf":
                case "terrainsetup":
                case "texarray":
                case "textarray":
                case "traffic_collisions":
                case "traffic_persistent":
                case "usm":
                case "voicetags":
                case "w2l":
                case "w2mesh":
                case "w2mi":
                case "w2mg":
                case "w3occulsion":
                case "w3dyng":
                case "wem":
                case "workspot":
                case "xbm":
                case "xcube":
                case "xml":
                case "w2sf":
                case "w2steer":
                case "w2ter":
                case "w2w":
                case "wizdef":
                case "w2ragdoll":
                case "app":
                case "spatial_representation":
                case "mlsetup":
                case "opusinfo":
                case "w3fac":
                case "actionanimdb":
                case "acousticdata":
                case "cellmap":
                case "csv":
                case "ent":
                case "guiconfig":
                case "hud":
                case "navgraph":
                case "reddest":
                case "redicsv":
                case "redswf":
                case "redwpset":
                case "w2em":
                case "w2ent":
                case "w2fnt":
                case "w2je":
                case "w2job":
                case "w2p":
                case "w2qm":
                case "w2rig":
                case "w2scene":
                case "w3app":

                    return $"Icons/Files/{extension}.svg";

                case "w2cutscene":
                    return $"RedEngine/{extension}.png";


                case "apx":
                case "ctw":
                case "dds":
                case "ebv":
                case "env":
                case "gidata":
                case "gradient":
                case "jpeg":
                case "jpg":
                case "lipmap":
                case "mlmask":
                case "mltemplate":
                case "no":
                case "png":
                case "psd":
                case "tga":
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
                case "w2faces":
                case "w2phase":
                case "w2quest":
                case "w2rag":
                case "xcf":
                case "zip":
                case "bin":

                default:
                    return $"Icons/Files/default.svg";
            }
        }

        #endregion Methods
    }


    public class ExtensionToBitmapConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var extension = value.ToString();
            if (!string.IsNullOrEmpty(extension))
            {
                if (extension.Length > 1)
                {
                    var result = GetSmallIconForFileType(extension) ?? "Icons/Files/default.svg";
                    var curFile = "pack://application:,,,/WolvenKit;component/Resources/Media/Images/" + result;
                    var IconExists = File.Exists(curFile);



                    if (IconExists)
                    {

                        return new Uri("pack://application:,,,/WolvenKit;component/Resources/Media/Images/" + result);

                    }
                }
                else
                {
                    return new Uri("pack://application:,,,/WolvenKit;component/Resources/Media/Images/Icons/Files/default.svg");

                }
            }
            return new Uri("pack://application:,,,/WolvenKit;component/Resources/Media/Images/Icons/Files/default.svg");
        }

        // No need to implement converting back on a one-way binding
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => DependencyProperty.UnsetValue;

        private static string GetSmallIconForFileType(string extension)
        {
            extension = extension.TrimStart('.').Trim();
            var defaultreturn = "Icons/Files/default.svg";


            if (!Enum.IsDefined(typeof(ECustomImageKeys), extension))
            {
                extension = extension.ToLower();
            }
            if (extension.Length > 0)
            {



                switch (extension)
                {
                    case nameof(ECustomImageKeys.OpenDirImageKey):
                        defaultreturn = "Icons/Files/folderopened.svg";
                        break;

                    case nameof(ECustomImageKeys.ClosedDirImageKey):
                        return "Icons/Files/folderdefault.svg";

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
                        defaultreturn = "Icons/Files/folderclosed.svg";
                        break;







                    //defaultreturn = $"Icons/Files/{extension}.svg";
                    //break;


                    //  case "w2cutscene":
                    //  defaultreturn = $"RedEngine/{extension}.png";
                    //  break;

                    case "aiarch":
                    case "animgraph":
                    case "anims":
                    case "apb":
                    case "archetypes":
                    case "areas":
                    case "audio_metadata":
                    case "audiovehcurveset":
                    case "behavior":
                    case "bikecurveset":
                    case "bk2":
                    case "blend":
                    case "bnk":
                    case "buffer":
                    case "camcurveset":
                    case "cfoliage":
                    case "charcustpreset":
                    case "cminimap":
                    case "community":
                    case "conversations":
                    case "cooked_mlsetup":
                    case "cookedanims":
                    case "cookedapp":
                    case "credits":
                    case "cubemap":
                    case "curveset":
                    case "dat":
                    case "devices":
                    case "dtex":
                    case "effect":
                    case "envparam":
                    case "envprobe":
                    case "es":
                    case "facialcustom":
                    case "facialsetup":
                    case "fb2tl":
                    case "fbx":
                    case "flyr":
                    case "fnt":
                    case "folbrush":
                    case "foldest":
                    case "font":
                    case "formation":
                    case "fp":
                    case "gamedef":
                    case "garmentlayerparams":
                    case "genericanimdb":
                    case "geometry_cache":
                    case "grassmask":
                    case "hitrepresentation":
                    case "hp":
                    case "ies":
                    case "inkanim":
                    case "inkatlas":
                    case "inkcharcustomization":
                    case "inkfontfamily":
                    case "inkfullscreencomposition":
                    case "inkgamesettings":
                    case "inkhud":
                    case "inklayers":
                    case "inkmenu":
                    case "inkshapecollection":
                    case "inkstyle":
                    case "inktypography":
                    case "inkwidget":
                    case "interaction":
                    case "journal":
                    case "journaldesc":
                    case "json":
                    case "lane_connections":
                    case "lane_polygons":
                    case "lane_spots":
                    case "lights":
                    case "location":
                    case "locopaths":
                    case "loot":
                    case "mappins":
                    case "menu":
                    case "mesh":
                    case "mi":
                    case "morphtarget":
                    case "mt":
                    case "navconfig":
                    case "naviobstacles":
                    case "navmesh":
                    case "navtile":
                    case "null_areas":
                    case "opuspak":
                    case "particle":
                    case "phys":
                    case "physicalscene":
                    case "physmatlib":
                    case "poimappins":
                    case "popup":
                    case "psrep":
                    case "quest":
                    case "questphase":
                    case "redapex":
                    case "redcloth":
                    case "reddlc":
                    case "redexp":
                    case "redfur":
                    case "redgame":
                    case "regionset":
                    case "remt":
                    case "reslist":
                    case "rig":
                    case "sav":
                    case "scene":
                    case "scenerid":
                    case "scenesversions":
                    case "w3simplex":
                    case "smartobject":
                    case "smartobjects":
                    case "sp":
                    case "spawntree":
                    case "srt":
                    case "streamingquerydata":
                    case "streamingsector":
                    case "streamingsector_inplace":
                    case "streamingworld":
                    case "subs":
                    case "swf":
                    case "terrainsetup":
                    case "texarray":
                    case "textarray":
                    case "traffic_collisions":
                    case "traffic_persistent":
                    case "usm":
                    case "voicetags":
                    case "w2l":
                    case "w2mesh":
                    case "w2mi":
                    case "w2mg":
                    case "w3occulsion":
                    case "w3dyng":
                    case "wem":
                    case "workspot":
                    case "xbm":
                    case "xcube":
                    case "xml":
                    case "w2sf":
                    case "w2steer":
                    case "w2ter":
                    case "w2w":
                    case "wizdef":
                    case "w2ragdoll":
                    case "app":
                    case "spatial_representation":
                    case "mlsetup":
                    case "opusinfo":
                    case "w3fac":
                    case "actionanimdb":
                    case "acousticdata":
                    case "cellmap":
                    case "csv":
                    case "ent":
                    case "guiconfig":
                    case "hud":
                    case "navgraph":
                    case "reddest":
                    case "redicsv":
                    case "redswf":
                    case "redwpset":
                    case "w2em":
                    case "w2ent":
                    case "w2fnt":
                    case "w2je":
                    case "w2job":
                    case "w2p":
                    case "w2qm":
                    case "w2rig":
                    case "w2scene":
                    case "w3app":
                    case "apx":
                    case "ctw":
                    case "dds":
                    case "ebv":
                    case "env":
                    case "gidata":
                    case "gradient":
                    case "jpeg":
                    case "jpg":
                    case "lipmap":
                    case "mlmask":
                    case "mltemplate":
                    case "no":
                    case "png":
                    case "psd":
                    case "tga":
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
                    case "w2faces":
                    case "w2phase":
                    case "w2quest":
                    case "w2rag":
                    case "xcf":
                    case "zip":
                    case "bin":

                    default:
                        defaultreturn = "Icons/Files/default.svg";
                        break;
                }
                return defaultreturn;

            }
            else
            {
                return defaultreturn;
            }
        }

        #endregion Methods
    }
}
