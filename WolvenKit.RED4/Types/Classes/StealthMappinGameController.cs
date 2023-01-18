using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StealthMappinGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("controller")] 
		public CWeakHandle<gameuiStealthMappinController> Controller
		{
			get => GetPropertyValue<CWeakHandle<gameuiStealthMappinController>>();
			set => SetPropertyValue<CWeakHandle<gameuiStealthMappinController>>(value);
		}

		[Ordinal(3)] 
		[RED("ownerNPC")] 
		public CWeakHandle<NPCPuppet> OwnerNPC
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		public StealthMappinGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
