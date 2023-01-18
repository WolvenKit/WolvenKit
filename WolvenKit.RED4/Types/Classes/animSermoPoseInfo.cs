using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSermoPoseInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lod")] 
		public CUInt8 Lod
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CUInt8 Type
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("trackIndex")] 
		public CUInt16 TrackIndex
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public animSermoPoseInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
