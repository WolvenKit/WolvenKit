using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMorphTargetMeshBlobTextureData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetDiffScale", 3)] 
		public CStatic<Vector4> TargetDiffScale
		{
			get => GetPropertyValue<CStatic<Vector4>>();
			set => SetPropertyValue<CStatic<Vector4>>(value);
		}

		[Ordinal(1)] 
		[RED("targetDiffOffset", 3)] 
		public CStatic<Vector4> TargetDiffOffset
		{
			get => GetPropertyValue<CStatic<Vector4>>();
			set => SetPropertyValue<CStatic<Vector4>>(value);
		}

		[Ordinal(2)] 
		[RED("targetDiffsDataOffset", 3)] 
		public CStatic<CUInt32> TargetDiffsDataOffset
		{
			get => GetPropertyValue<CStatic<CUInt32>>();
			set => SetPropertyValue<CStatic<CUInt32>>(value);
		}

		[Ordinal(3)] 
		[RED("targetDiffsDataSize", 3)] 
		public CStatic<CUInt32> TargetDiffsDataSize
		{
			get => GetPropertyValue<CStatic<CUInt32>>();
			set => SetPropertyValue<CStatic<CUInt32>>(value);
		}

		[Ordinal(4)] 
		[RED("targetDiffsWidth", 3)] 
		public CStatic<CUInt16> TargetDiffsWidth
		{
			get => GetPropertyValue<CStatic<CUInt16>>();
			set => SetPropertyValue<CStatic<CUInt16>>(value);
		}

		[Ordinal(5)] 
		[RED("targetDiffsMipLevelCounts", 3)] 
		public CStatic<CUInt8> TargetDiffsMipLevelCounts
		{
			get => GetPropertyValue<CStatic<CUInt8>>();
			set => SetPropertyValue<CStatic<CUInt8>>(value);
		}

		public rendRenderMorphTargetMeshBlobTextureData()
		{
			TargetDiffScale = new(3);
			TargetDiffOffset = new(3);
			TargetDiffsDataOffset = new(3);
			TargetDiffsDataSize = new(3);
			TargetDiffsWidth = new(3);
			TargetDiffsMipLevelCounts = new(3);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
