using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCompiledEffectPlacementInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("placementTagIndex")] 
		public CUInt8 PlacementTagIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("relativePositionIndex")] 
		public CUInt8 RelativePositionIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("relativeRotationIndex")] 
		public CUInt8 RelativeRotationIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldCompiledEffectPlacementInfo()
		{
			PlacementTagIndex = 255;
			RelativePositionIndex = 255;
			RelativeRotationIndex = 255;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
