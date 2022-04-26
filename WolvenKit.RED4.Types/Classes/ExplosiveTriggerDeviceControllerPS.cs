using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExplosiveTriggerDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(120)] 
		[RED("playerSafePass")] 
		public CBool PlayerSafePass
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(121)] 
		[RED("triggerExploded")] 
		public CBool TriggerExploded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExplosiveTriggerDeviceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
