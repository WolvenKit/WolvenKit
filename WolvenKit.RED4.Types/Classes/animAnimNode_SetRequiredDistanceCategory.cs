using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetRequiredDistanceCategory : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("requiredQualityDistanceCategory")] 
		public CUInt32 RequiredQualityDistanceCategory
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animAnimNode_SetRequiredDistanceCategory()
		{
			Id = 4294967295;
			InputLink = new();
			RequiredQualityDistanceCategory = 4;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
