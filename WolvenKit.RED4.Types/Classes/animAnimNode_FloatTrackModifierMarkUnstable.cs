using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloatTrackModifierMarkUnstable : animAnimNode_FloatTrackModifier
	{
		private CUInt32 _requiredQualityDistanceCategory;

		[Ordinal(16)] 
		[RED("requiredQualityDistanceCategory")] 
		public CUInt32 RequiredQualityDistanceCategory
		{
			get => GetProperty(ref _requiredQualityDistanceCategory);
			set => SetProperty(ref _requiredQualityDistanceCategory, value);
		}

		public animAnimNode_FloatTrackModifierMarkUnstable()
		{
			_requiredQualityDistanceCategory = 4;
		}
	}
}
