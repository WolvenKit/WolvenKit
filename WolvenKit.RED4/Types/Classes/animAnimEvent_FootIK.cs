using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_FootIK : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("leg")] 
		public CEnum<animLeg> Leg
		{
			get => GetPropertyValue<CEnum<animLeg>>();
			set => SetPropertyValue<CEnum<animLeg>>(value);
		}

		public animAnimEvent_FootIK()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
