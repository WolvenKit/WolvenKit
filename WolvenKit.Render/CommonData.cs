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
        public CSkeleton meshSkeleton = new CSkeleton();
        public BoneData boneData = new BoneData();
        public List<Vector3Df> bonePositions = new List<Vector3Df>();
        public W3_DataCache w3_DataCache = new W3_DataCache();

        public float animationSpeed = 0;
        public List<List<uint>> positionsKeyframes = new List<List<uint>>();
        public List<List<uint>> orientKeyframes = new List<List<uint>>();
        public List<List<uint>> scalesKeyframes = new List<List<uint>>();
        public List<List<Vector3Df>> positions = new List<List<Vector3Df>>();
        public List<List<Quaternion>> orientations = new List<List<Quaternion>>();
        public List<List<Vector3Df>> scales = new List<List<Vector3Df>>();

        public const float PI_OVER_180 = (float)Math.PI / 180.0f;
    }
}