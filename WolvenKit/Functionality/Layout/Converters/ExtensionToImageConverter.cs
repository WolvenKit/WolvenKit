using System;
using System.Globalization;
using System.Windows;
using Catel.MVVM.Converters;
using WolvenKit.Common;

namespace WolvenKit.Functionality.Layout.Converters
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

            if (!string.IsNullOrEmpty(extension))
            {
                var result = GetSmallIconForFileType(extension);
                var uri = new Uri("pack://application:,,,/WolvenKit;component/Resources/Media/Images/" + result);


                return uri;
            }

            return string.Empty;
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
                    return $"Icons/Files/aiarch3.svg";
                case "animgraph":
                    return $"Icons/Files/aningraph.svg";
                case "anims":
                    return $"Icons/Files/animation.svg";
                case "audio_metadata":
                    return $"Icons/Files/audiometadata2.svg";
                case "behavior":
                    return $"Icons/Files/behavior_graph3.svg";
                case "camcurveset":
                    return $"Icons/Files/camcurveset2.svg";
                case "credits":
                    return $"Icons/Files/credits2.svg";
                case "devices":
                    return $"Icons/Files/Devices.svg";
                case "effect":
                    return $"Icons/Files/Effect.svg";
                case "envprobe":
                    return $"Icons/Files/envprob a.svg";
                case "inkanim":
                    return $"Icons/Files/inkanim2.svg";
                case "inkatlas":
                    return $"Icons/Files/inkatlas3.svg";
                case "inkfontfamily":
                    return $"Icons/Files/inkfont.svg";
                case "inkfullscreencomposition":
                    return $"Icons/Files/inkscreencomp.svg";
                case "inklayers":
                    return $"Icons/Files/inklayers2.svg";
                case "inkmenu":
                    return $"Icons/Files/inkmenu3.svg";
                case "inkshapecollection":
                    return $"Icons/Files/inkshapecollection2.svg";
                case "inktypography":
                    return $"Icons/Files/inktypography2.svg";
                case "interaction":
                    return $"Icons/Files/Interaction.svg";
                case "journal":
                    return $"Icons/Files/journal2.svg";
                case "reslist":
                    return $"Icons/Files/resourcelist2.svg";
                case "scene":
                    return $"Icons/Files/scene_Cutscene.svg";
                case "scenerid":
                    return $"Icons/Files/scenerid_Cutscene_info.svg";
                case "scenesversions":
                    return $"Icons/Files/scenesversions_Cutscene_versioning.svg";
                case "traffic_persistent":
                    return $"Icons/Files/traffic_persistent2.svg";
                case "voicetags":
                    return $"Icons/Files/VoiceTags.svg";
                case "w3occulsion":
                    return $"Icons/Files/W3Occulsion.svg";
                case "workspot":
                    return $"Icons/Files/workspot3.svg";

                case "apb":
                case "audiovehcurveset":
                case "bk2":
                case "blend":
                case "bnk":
                case "cfoliage":
                case "charcustpreset":
                case "cminimap":
                case "conversations":
                case "cookedanims":
                case "cookedapp":
                case "cubemap":
                case "curveset":
                case "dat":
                case "envparam":
                case "facialsetup":
                case "fbx":
                case "folbrush":
                case "foldest":
                case "gamedef":
                case "hp":
                case "inkcharcustomization":
                case "inkgamesettings":
                case "inkhud":
                case "inkstyle":
                case "inkwidget":
                case "journaldesc":
                case "json":
                case "lane_connections":
                case "lane_polygons":
                case "lights":
                case "location":
                case "loot":
                case "mappins":
                case "mesh":
                case "mi":
                case "navmesh":
                case "null_areas":
                case "opuspak":
                case "particle":
                case "poimappins":
                case "quest":
                case "questphase":
                case "rig":
                case "texarray":
                case "traffic_collisions":
                case "w2mesh":
                case "wem":
                case "xbm":
                case "xcube":
                case "xml":
                    return $"Icons/Files/{extension}.svg";

                case "w2cutscene":
                    return $"RedEngine/{extension}.png";
                case "w2mi":
                    return $"Icons/Files/{extension}2.svg";

                case "acousticdata":
                case "actionanimdb":
                case "app":
                case "apx":
                case "archetypes":
                case "areas":
                case "bikecurveset":
                case "buffer":
                case "cellmap":
                case "community":
                case "cooked_mlsetup":
                case "csv":
                case "ctw":
                case "dds":
                case "dtex":
                case "ebv":
                case "ent":
                case "env":
                case "es":
                case "facialcustom":
                case "fb2tl":
                case "flyr":
                case "fnt":
                case "formation":
                case "fp":
                case "garmentlayerparams":
                case "genericanimdb":
                case "gidata":
                case "gradient":
                case "grassmask":
                case "guiconfig":
                case "hitrepresentation":
                case "hud":
                case "ies":
                case "jpeg":
                case "jpg":
                case "lane_spots":
                case "lipmap":
                case "locopaths":
                case "menu":
                case "mlmask":
                case "mlsetup":
                case "mltemplate":
                case "morphtarget":
                case "mt":
                case "navconfig":
                case "navgraph":
                case "naviobstacles":
                case "navtile":
                case "no":
                case "opusinfo":
                case "phys":
                case "physicalscene":
                case "physmatlib":
                case "png":
                case "popup":
                case "psd":
                case "psrep":
                case "redapex":
                case "redcloth":
                case "reddest":
                case "reddlc":
                case "redexp":
                case "redfur":
                case "redgame":
                case "redicsv":
                case "redswf":
                case "redwpset":
                case "regionset":
                case "remt":
                case "sav":
                case "smartobject":
                case "smartobjects":
                case "sp":
                case "spatial_representation":
                case "spawntree":
                case "srt":
                case "streamingquerydata":
                case "streamingsector":
                case "streamingsector_inplace":
                case "streamingworld":
                case "subs":
                case "swf":
                case "terrainsetup":
                case "textarray":
                case "tga":
                case "usm":
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
                case "w2em":
                case "w2ent":
                case "w2faces":
                case "w2fnt":
                case "w2je":
                case "w2job":
                case "w2l":
                case "w2mg":
                case "w2p":
                case "w2phase":
                case "w2qm":
                case "w2quest":
                case "w2rag":
                case "w2ragdoll":
                case "w2rig":
                case "w2scene":
                case "w2sf":
                case "w2steer":
                case "w2ter":
                case "w2w":
                case "w3app":
                case "w3dyng":
                case "w3fac":
                case "w3simplex":
                case "wizdef":
                case "xcf":
                case "zip":





                default:
                    return $"Icons/Files/file.svg";
            }
        }

        #endregion Methods
    }
}
