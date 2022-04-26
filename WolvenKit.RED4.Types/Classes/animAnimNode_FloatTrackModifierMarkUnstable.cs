using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatTrackModifierMarkUnstable : animAnimNode_FloatTrackModifier
	{
		[Ordinal(16)] 
		[RED("requiredQualityDistanceCategory")] 
		public CUInt32 RequiredQualityDistanceCategory
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animAnimNode_FloatTrackModifierMarkUnstable()
		{
			RequiredQualityDistanceCategory = 4;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
