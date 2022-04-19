using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshChunkIndicesOffset : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("start")] 
		public CUInt32 Start
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("boneIndex")] 
		public CUInt8 BoneIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public meshChunkIndicesOffset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
