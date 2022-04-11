using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArmsCWInSlotPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<ArmsCWInSlotCallback> Listener
		{
			get => GetPropertyValue<CHandle<ArmsCWInSlotCallback>>();
			set => SetPropertyValue<CHandle<ArmsCWInSlotCallback>>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ArmsCWInSlotPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
