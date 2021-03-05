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
            extension = extension.ToLower();
            extension = extension.TrimStart('.').Trim();
            switch (extension)
            {
                case "actionanimdb":
                    return $"Icons/Files/folderdefault.svg";

                case "acousticdata":
                    return $"Icons/Files/folderdefault.svg";

                case "aiarch":
                    return $"Icons/Files/aiarch3.svg";
                case "animgraph":
                    return $"Icons/Files/aningraph.svg";
                case "anims":
                    return $"Icons/Files/animation.svg";
                case "app":
                    return $"Icons/Files/folderdefault.svg";

                case "archetypes":
                    return $"Icons/Files/folderdefault.svg";

                case "areas":
                    return $"Icons/Files/folderdefault.svg";

                case "audio_metadata":
                    return $"Icons/Files/audiometadata2.svg";
                case "audiovehcurveset":
                    return $"Icons/Files/{extension}.svg";
                case "behavior":
                    return $"Icons/Files/behavior_graph3.svg";
                case "bikecurveset":
                    return $"Icons/Files/folderdefault.svg";

                case "bk2":
                    return $"Icons/Files/{extension}.svg";
                case "bnk":
                    return $"Icons/Files/{extension}.svg";
                case "camcurveset":
                    return $"Icons/Files/camcurveset2.svg";
                case "cfoliage":
                    return $"Icons/Files/{extension}.svg";
                case "charcustpreset":
                    return $"Icons/Files/{extension}.svg";
                case "cminimap":
                    return $"Icons/Files/{extension}.svg";
                case "community":
                    return $"Icons/Files/folderdefault.svg";

                case "conversations":
                    return $"Icons/Files/{extension}.svg";
                case "cooked_mlsetup":
                    return $"Icons/Files/folderdefault.svg";

                case "cookedanims":
                    return $"Icons/Files/{extension}.svg";
                case "cookedapp":
                    return $"Icons/Files/{extension}.svg";
                case "credits":
                    return $"Icons/Files/credits2.svg";
                case "csv":
                    return $"Icons/Files/folderdefault.svg";

                case "cubemap":
                    return $"Icons/Files/{extension}.svg";
                case "curveset":
                    return $"Icons/Files/{extension}.svg";
                case "dat":
                    return $"Icons/Files/{extension}.svg";
                case "devices":
                    return $"Icons/Files/Devices.svg";
                case "dtex":
                    return $"Icons/Files/folderdefault.svg";

                case "effect":
                    return $"Icons/Files/Effect.svg";
                case "ent":
                    return $"Icons/Files/folderdefault.svg";

                case "env":
                    return $"Icons/Files/folderdefault.svg";

                case "envparam":
                    return $"Icons/Files/{extension}.svg";
                case "envprobe":
                    return $"Icons/Files/envprob a.svg";
                case "es":
                    return $"Icons/Files/folderdefault.svg";

                case "facialcustom":
                    return $"Icons/Files/folderdefault.svg";

                case "facialsetup":
                    return $"Icons/Files/{extension}.svg";
                case "fb2tl":
                    return $"Icons/Files/folderdefault.svg";

                case "fnt":
                    return $"Icons/Files/folderdefault.svg";

                case "folbrush":
                    return $"Icons/Files/{extension}.svg";
                case "foldest":
                    return $"Icons/Files/{extension}.svg";
                case "fp":
                    return $"Icons/Files/folderdefault.svg";

                case "gamedef":
                    return $"Icons/Files/{extension}.svg";
                case "garmentlayerparams":
                    return $"Icons/Files/folderdefault.svg";

                case "genericanimdb":
                    return $"Icons/Files/folderdefault.svg";

                case "no":
                    return $"Icons/Files/folderdefault.svg";

                case "gidata":
                    return $"Icons/Files/folderdefault.svg";

                case "gradient":
                    return $"Icons/Files/folderdefault.svg";

                case "hitrepresentation":
                    return $"Icons/Files/folderdefault.svg";

                case "hp":
                    return $"Icons/Files/{extension}.svg";
                case "ies":
                    return $"Icons/Files/folderdefault.svg";

                case "inkanim":
                    return $"Icons/Files/inkanim2.svg";
                case "inkatlas":
                    return $"Icons/Files/inkatlas3.svg";
                case "inkcharcustomization":
                    return $"Icons/Files/{extension}.svg";
                case "inkfontfamily":
                    return $"Icons/Files/inkfont.svg";
                case "inkfullscreencomposition":
                    return $"Icons/Files/inkscreencomp.svg";
                case "inkgamesettings":
                    return $"Icons/Files/{extension}.svg";
                case "inkhud":
                    return $"Icons/Files/{extension}.svg";
                case "inklayers":
                    return $"Icons/Files/inklayers2.svg";
                case "inkmenu":
                    return $"Icons/Files/inkmenu3.svg";
                case "inkshapecollection":
                    return $"Icons/Files/inkshapecollection2.svg";
                case "inkstyle":
                    return $"Icons/Files/{extension}.svg";
                case "inktypography":
                    return $"Icons/Files/inktypography2.svg";
                case "inkwidget":
                    return $"Icons/Files/{extension}.svg";
                case "interaction":
                    return $"Icons/Files/Interaction.svg";
                case "journal":
                    return $"Icons/Files/journal2.svg";
                case "journaldesc":
                    return $"Icons/Files/{extension}.svg";
                case "json":
                    return $"Icons/Files/{extension}.svg";
                case "lane_connections":
                    return $"Icons/Files/{extension}.svg";
                case "lane_polygons":
                    return $"Icons/Files/{extension}.svg";
                case "lane_spots":
                    return $"Icons/Files/folderdefault.svg";

                case "lights":
                    return $"Icons/Files/{extension}.svg";
                case "lipmap":
                    return $"Icons/Files/folderdefault.svg";

                case "location":
                    return $"Icons/Files/{extension}.svg";
                case "locopaths":
                    return $"Icons/Files/folderdefault.svg";

                case "loot":
                    return $"Icons/Files/{extension}.svg";
                case "mappins":
                    return $"Icons/Files/{extension}.svg";
                case "mesh":
                    return $"Icons/Files/{extension}.svg";
                case "mi":
                    return $"Icons/Files/{extension}.svg";
                case "mlmask":
                    return $"Icons/Files/folderdefault.svg";

                case "mlsetup":
                    return $"Icons/Files/folderdefault.svg";

                case "mltemplate":
                    return $"Icons/Files/folderdefault.svg";

                case "morphtarget":
                    return $"Icons/Files/folderdefault.svg";

                case "mt":
                    return $"Icons/Files/folderdefault.svg";

                case "navmesh":
                    return $"Icons/Files/{extension}.svg";
                case "null_areas":
                    return $"Icons/Files/{extension}.svg";
                case "opusinfo":
                    return $"Icons/Files/folderdefault.svg";

                case "opuspak":
                    return $"Icons/Files/{extension}.svg";
                case "particle":
                    return $"Icons/Files/{extension}.svg";
                case "phys":
                    return $"Icons/Files/folderdefault.svg";

                case "physicalscene":
                    return $"Icons/Files/folderdefault.svg";

                case "physmatlib":
                    return $"Icons/Files/folderdefault.svg";

                case "poimappins":
                    return $"Icons/Files/{extension}.svg";
                case "psrep":
                    return $"Icons/Files/folderdefault.svg";

                case "quest":
                    return $"Icons/Files/{extension}.svg";
                case "questphase":
                    return $"Icons/Files/{extension}.svg";
                case "regionset":
                    return $"Icons/Files/folderdefault.svg";

                case "remt":
                    return $"Icons/Files/folderdefault.svg";

                case "reslist":
                    return $"Icons/Files/resourcelist2.svg";
                case "rig":
                    return $"Icons/Files/{extension}.svg";
                case "scene":
                    return $"Icons/Files/scene_Cutscene.svg";
                case "scenerid":
                    return $"Icons/Files/scenerid_Cutscene_info.svg";
                case "scenesversions":
                    return $"Icons/Files/scenesversions_Cutscene_versioning.svg";
                case "smartobject":
                    return $"Icons/Files/folderdefault.svg";

                case "smartobjects":
                    return $"Icons/Files/folderdefault.svg";

                case "sp":
                    return $"Icons/Files/folderdefault.svg";

                case "spatial_representation":
                    return $"Icons/Files/folderdefault.svg";

                case "streamingquerydata":
                    return $"Icons/Files/folderdefault.svg";

                case "streamingsector":
                    return $"Icons/Files/folderdefault.svg";

                case "streamingsector_inplace":
                    return $"Icons/Files/folderdefault.svg";

                case "streamingworld":
                    return $"Icons/Files/folderdefault.svg";

                case "terrainsetup":
                    return $"Icons/Files/folderdefault.svg";

                case "texarray":
                    return $"Icons/Files/{extension}.svg";
                case "traffic_collisions":
                    return $"Icons/Files/{extension}.svg";
                case "traffic_persistent":
                    return $"Icons/Files/traffic_persistent2.svg";
                case "voicetags":
                    return $"Icons/Files/VoiceTags.svg";
                case "w2mesh":
                    return $"Icons/Files/{extension}.svg";
                case "w2mi":
                    return $"Icons/Files/{extension}2.svg";
                case "wem":
                    return $"Icons/Files/{extension}.svg";
                case "workspot":
                    return $"Icons/Files/workspot3.svg";
                case "xbm":
                    return $"Icons/Files/{extension}.svg";
                case "xcube":
                    return $"Icons/Files/{extension}.svg";
                case "xml":
                    return $"Icons/Files/{extension}.svg";
                case "wizdef":
                    return $"Icons/Files/folderdefault.svg";

                case "w3simplex":
                    return $"Icons/Files/folderdefault.svg";

                case "w3occulsion":
                    return $"Icons/Files/W3Occulsion.svg";
                case "w3fac":
                    return $"Icons/Files/folderdefault.svg";

                case "w3dyng":
                    return $"Icons/Files/folderdefault.svg";

                case "w3app":
                    return $"Icons/Files/folderdefault.svg";

                case "w2w":
                    return $"Icons/Files/folderdefault.svg";

                case "w2ter":
                    return $"Icons/Files/folderdefault.svg";

                case "w2steer":
                    return $"Icons/Files/folderdefault.svg";

                case "w2sf":
                    return $"Icons/Files/folderdefault.svg";

                case "w2scene":
                    return $"Icons/Files/folderdefault.svg";

                case "w2rig":
                    return $"Icons/Files/folderdefault.svg";

                case "w2ragdoll":
                    return $"Icons/Files/folderdefault.svg";

                case "w2quest":
                    return $"Icons/Files/folderdefault.svg";

                case "w2qm":
                    return $"Icons/Files/folderdefault.svg";

                case "w2phase":
                    return $"Icons/Files/folderdefault.svg";

                case "w2p":
                    return $"Icons/Files/folderdefault.svg";

                case "w2mg":
                    return $"Icons/Files/folderdefault.svg";

                case "w2l":
                    return $"Icons/Files/folderdefault.svg";

                case "w2job":
                    return $"Icons/Files/folderdefault.svg";

                case "w2je":
                    return $"Icons/Files/folderdefault.svg";

                case "w2fnt":
                    return $"Icons/Files/folderdefault.svg";

                case "w2ent":
                    return $"Icons/Files/folderdefault.svg";

                case "w2em":
                    return $"Icons/Files/folderdefault.svg";

                case "vbrush":
                    return $"Icons/Files/folderdefault.svg";

                case "usm":
                    return $"Icons/Files/folderdefault.svg";

                case "textarray":
                    return $"Icons/Files/folderdefault.svg";

                case "subs":
                    return $"Icons/Files/folderdefault.svg";

                case "srt":
                    return $"Icons/Files/folderdefault.svg";

                case "spawntree":
                    return $"Icons/Files/folderdefault.svg";

                case "sav":
                    return $"Icons/Files/folderdefault.svg";

                case "redwpset":
                    return $"Icons/Files/folderdefault.svg";

                case "redswf":
                    return $"Icons/Files/folderdefault.svg";

                case "redicsv":
                    return $"Icons/Files/folderdefault.svg";

                case "redgame":
                    return $"Icons/Files/folderdefault.svg";

                case "redfur":
                    return $"Icons/Files/folderdefault.svg";

                case "redexp":
                    return $"Icons/Files/folderdefault.svg";

                case "reddlc":
                    return $"Icons/Files/folderdefault.svg";

                case "reddest":
                    return $"Icons/Files/folderdefault.svg";

                case "redcloth":
                    return $"Icons/Files/folderdefault.svg";

                case "redapex":
                    return $"Icons/Files/folderdefault.svg";

                case "popup":
                    return $"Icons/Files/folderdefault.svg";

                case "navtile":
                    return $"Icons/Files/folderdefault.svg";

                case "naviobstacles":
                    return $"Icons/Files/folderdefault.svg";

                case "navgraph":
                    return $"Icons/Files/folderdefault.svg";

                case "navconfig":
                    return $"Icons/Files/folderdefault.svg";

                case "menu":
                    return $"Icons/Files/folderdefault.svg";

                case "hud":
                    return $"Icons/Files/folderdefault.svg";

                case "guiconfig":
                    return $"Icons/Files/folderdefault.svg";

                case "grassmask":
                    return $"Icons/Files/folderdefault.svg";

                case "formation":
                    return $"Icons/Files/folderdefault.svg";

                case "flyr":
                    return $"Icons/Files/folderdefault.svg";

                case "ebv":
                    return $"Icons/Files/folderdefault.svg";

                case "cellmap":
                    return $"Icons/Files/folderdefault.svg";

                case "buffer":
                    return $"Icons/Files/folderdefault.svg";


                case "w2faces":
                    return $"Icons/Files/folderdefault.svg";


                case "w2rag":
                    return $"Icons/Files/folderdefault.svg";


                case "swf":
                    return $"Icons/Files/folderdefault.svg";


                case "w2anim":
                    return $"Icons/Files/folderdefault.svg";


                case "w2animev":
                    return $"Icons/Files/folderdefault.svg";


                case "w2anims":
                    return $"Icons/Files/folderdefault.svg";


                case "w2beh":
                    return $"Icons/Files/folderdefault.svg";


                case "w2behtree":
                    return $"Icons/Files/folderdefault.svg";


                case "w2cent":
                    return $"Icons/Files/folderdefault.svg";


                case "w2comm":
                    return $"Icons/Files/folderdefault.svg";


                case "w2conv":
                    return $"Icons/Files/folderdefault.svg";


                case "w2cube":
                    return $"Icons/Files/folderdefault.svg";


                case "w2cutscene":
                    return $"RedEngine/{extension}.png";

                case "fbx":
                    return $"Icons/Files/{extension}.svg";

                case "apb":
                    return $"Icons/Files/{extension}.svg";

                case "blend":
                    return $"Icons/Files/{extension}.svg";

                case "zip":
                    return $"Icons/Files/{extension}.svg";

                case "tga":
                    return $"Icons/Files/image.svg";

                case "png":
                    return $"Icons/Files/image.svg";

                case "dds":
                    return $"Icons/Files/image.svg";

                case "jpg":
                    return $"Icons/Files/image.svg";

                case "jpeg":
                    return $"Icons/Files/image.svg";

                case "xcf":
                    return $"Icons/Files/folderdefault.svg";


                case "psd":
                    return $"Icons/Files/folderdefault.svg";


                case "apx":
                    return $"Icons/Files/folderdefault.svg";


                case "ctw":
                    return $"Icons/Files/folderdefault.svg";


                case nameof(ECustomImageKeys.ClosedDirImageKey):
                    return $"Icons/Files/folderclosed.svg";

                case nameof(ECustomImageKeys.OpenDirImageKey):
                    return $"Icons/Files/folderopened.svg";

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

                default:
                    return $"Icons/Files/folderdefault.svg";
            }
        }

        #endregion Methods
    }
}
