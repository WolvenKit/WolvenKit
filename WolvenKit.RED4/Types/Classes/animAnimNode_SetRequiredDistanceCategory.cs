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
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			RequiredQualityDistanceCategory = 4;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
