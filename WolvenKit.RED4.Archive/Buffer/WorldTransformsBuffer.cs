using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class WorldTransformsBuffer : IParseableBuffer
    {
        public IRedType Data => Transforms;

        public CArray<WorldTransform> Transforms = new();

        public WorldTransformsBuffer()
        {

        }
    }
/*
    public partial class WorldTransformExt : WorldTransform
    {
        public Vector3 Scale = new();

        public WorldTransformExt() : base()
        {

        }
    }*/
}
