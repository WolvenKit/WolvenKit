using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Types
{
	public partial class worldCompiledNodeInstanceSetupInfo : RedBaseClass
	{
        // offset 0
        [Ordinal(0)]
        [RED("transform")]
        public Transform Transform
        {
            get => GetPropertyValue<Transform>();
            set => SetPropertyValue<Transform>(value);
        }

        // offset 32
        [Ordinal(1)]
        [RED("scale")]
        public Vector3 Scale
        {
            get => GetPropertyValue<Vector3>();
            set => SetPropertyValue<Vector3>(value);
        }


        // offset 44
        // was Pivot
        [Ordinal(2)]
        [RED("secondaryRefPointPosition")]
        public Vector3 SecondaryRefPointPosition
        {
            get => GetPropertyValue<Vector3>();
            set => SetPropertyValue<Vector3>(value);
        }

        // offset 56
        // was Bounds.min (.max not used?)
        // .min and .max are the same
        [Ordinal(3)]
        [RED("streamingRefPoint")]
        public Vector3 StreamingRefPoint
        {
            get => GetPropertyValue<Vector3>();
            set => SetPropertyValue<Vector3>(value);
        }

        // offset 68 - 70 is StreamingRefPoint again
        // offset 80 (not in metadata)
        [Ordinal(4)]
        [RED("id")]
        public CUInt64 Id
        {
            get => GetPropertyValue<CUInt64>();
            set => SetPropertyValue<CUInt64>(value);
        }

        // offset 88
        [Ordinal(5)]
        [RED("globalNodeId")]
        public worldGlobalNodeID GlobalNodeId
        {
            get => GetPropertyValue<worldGlobalNodeID>();
            set => SetPropertyValue<worldGlobalNodeID>(value);
        }

        // offset 96 (not in metadata)
        [Ordinal(6)]
        [RED("proxyNodeId")]
        public worldGlobalNodeID ProxyNodeId
        {
            get => GetPropertyValue<worldGlobalNodeID>();
            set => SetPropertyValue<worldGlobalNodeID>(value);
        }

        // offset 104 (not in metadata)
        [Ordinal(7)]
        [RED("cookedPrefabData")]
        public CResourceReference<worldCookedPrefabData> CookedPrefabData
        {
            get => GetPropertyValue<CResourceReference<worldCookedPrefabData>>();
            set => SetPropertyValue<CResourceReference<worldCookedPrefabData>>(value);
        }

        // offset 112
        // was MaxStreamingDistance
        [Ordinal(8)]
        [RED("secondaryRefPointDistance")]
        public CFloat SecondaryRefPointDistance
        {
            get => GetPropertyValue<CFloat>();
            set => SetPropertyValue<CFloat>(value);
        }

        // offset 116
        // was UknFloat1
        [Ordinal(9)]
        [RED("streamingDistance")]
        public CFloat StreamingDistance
        {
            get => GetPropertyValue<CFloat>();
            set => SetPropertyValue<CFloat>(value);
        }

        // offset 120
        [Ordinal(10)]
        [RED("nodeIndex")]
        public CUInt16 NodeIndex
        {
            get => GetPropertyValue<CUInt16>();
            set => SetPropertyValue<CUInt16>(value);
        }

        // all of these are shifted + 1
        [Ordinal(11)]
        [RED("uk11")]
        public CUInt16 Uk11
        {
            get => GetPropertyValue<CUInt16>();
            set => SetPropertyValue<CUInt16>(value);
        }

        [Ordinal(12)]
        [RED("uk12")]
        public CUInt16 Uk12
        {
            get => GetPropertyValue<CUInt16>();
            set => SetPropertyValue<CUInt16>(value);
        }

        [Ordinal(13)]
        [RED("uk13")]
        public CUInt16 Uk13
        {
            get => GetPropertyValue<CUInt16>();
            set => SetPropertyValue<CUInt16>(value);
        }

        [Ordinal(14)]
        [RED("uk14")]
        public CUInt64 Uk14
        {
            get => GetPropertyValue<CUInt64>();
            set => SetPropertyValue<CUInt64>(value);
        }

        [Ordinal(15)]
        [RED("uk15")]
        public CUInt64 Uk15
        {
            get => GetPropertyValue<CUInt64>();
            set => SetPropertyValue<CUInt64>(value);
        }

        public worldCompiledNodeInstanceSetupInfo()
		{
            Transform = new Transform();
            Scale = new Vector3();
            SecondaryRefPointPosition = new Vector3();
            StreamingRefPoint = new Vector3();
            GlobalNodeId = new worldGlobalNodeID();
            ProxyNodeId = new worldGlobalNodeID();
            CookedPrefabData = new CResourceReference<worldCookedPrefabData>();

			PostConstruct();
		}

		partial void PostConstruct();
    }
}
