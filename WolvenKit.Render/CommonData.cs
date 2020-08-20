using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using System;
using System.Collections.Generic;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Render
{
    public class CommonData
    {
        //public string modelPath = "";
        public StaticMesh staticMesh = StaticMesh.Create();
        public List<CMaterialInstance> materialInstances = new List<CMaterialInstance>();
        public List<SMeshInfos> meshInfos = new List<SMeshInfos>();
        public BoneData boneData = new BoneData();
        public W3_DataCache w3_DataCache = new W3_DataCache();

        public const float PI_OVER_180 = (float)Math.PI / 180.0f;
    }
}