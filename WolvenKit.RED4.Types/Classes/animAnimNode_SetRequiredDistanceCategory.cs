using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SetRequiredDistanceCategory : animAnimNode_OnePoseInput
	{
		private CUInt32 _requiredQualityDistanceCategory;

		[Ordinal(12)] 
		[RED("requiredQualityDistanceCategory")] 
		public CUInt32 RequiredQualityDistanceCategory
		{
			get => GetProperty(ref _requiredQualityDistanceCategory);
			set => SetProperty(ref _requiredQualityDistanceCategory, value);
		}
	}
}
