using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerIsNewPerkBoughtPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listenerPerksVariant")] 
		public CHandle<redCallbackObject> ListenerPerksVariant
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public PlayerIsNewPerkBoughtPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
