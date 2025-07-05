using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnGameplayActionSetVehicleSuspensionData : scnIGameplayActionData
	{
		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("cooldownTime")] 
		public CFloat CooldownTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scnGameplayActionSetVehicleSuspensionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
