using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SharedMetaPose : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_SharedMetaPose()
		{
			Id = 4294967295;
			InputLink = new();
			WeightLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
