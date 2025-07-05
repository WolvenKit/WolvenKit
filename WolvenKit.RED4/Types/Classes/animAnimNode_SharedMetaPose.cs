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
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			WeightLink = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
