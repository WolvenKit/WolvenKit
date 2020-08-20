using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Radish.Model
{
    public class RadishWorkflow
    {
        public RadishWorkflow()
        {

        }
        public RadishWorkflow(string name)
        {
            Name = name;
        }


        [Category("0 Misc")] public string Name { get; set; }

        [Description("If set to true, the game will automatically be launched after building. ")] [Category("0 Misc")] public bool START_GAME { get; set; }
        [Category("0 Misc")] public bool Cleanup_folder { get; set; }
        [Description("If set to true, dependency steps will automatically be set. ")] [Category("0 Misc")] public bool PATCH_MODE { get; set; }

        [Category("1 Radish")] public bool ENCODE_WORLD { get; set; }
        [Category("1 Radish")] public bool ENCODE_ENVS { get; set; }
        [Category("1 Radish")] public bool ENCODE_SCENES { get; set; }
        [Category("1 Radish")] public bool ENCODE_QUEST { get; set; }
        [Category("1 Radish")] public bool ENCODE_STRINGS { get; set; }
        [Category("1 Radish")] public bool ENCODE_SPEECH { get; set; }
        [Category("1 Radish")] public bool ENCODE_HAIRWORKS { get; set; }

        [Category("2 Wcc")] public bool WCC_IMPORT_MODELS { get; set; }
        [Category("2 Wcc")] public bool WCC_IMPORT_TEXTURES { get; set; }
        [Category("2 Wcc")] public bool WCC_COOK { get; set; }
        [Category("2 Wcc")] public bool WCC_NAVDATA { get; set; }
        [Category("2 Wcc")] public bool WCC_TEXTURECACHE { get; set; }
        [Category("2 Wcc")] public bool WCC_COLLISIONCACHE { get; set; }
        [Category("2 Wcc")] public bool WCC_ANALYZE { get; set; }
        [Category("2 Wcc")] public bool WCC_ANALYZE_WORLD { get; set; }

        [Category("3 Deploy")] public bool WCC_REPACK_DLC { get; set; }
        [Category("3 Deploy")] public bool WCC_REPACK_MOD { get; set; }
        [Category("3 Deploy")] public bool DEPLOY_SCRIPTS { get; set; }
        [Category("3 Deploy")] public bool DEPLOY_TMP_SCRIPTS { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
