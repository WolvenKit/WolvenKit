using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemInSlotPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<ItemInSlotCallback> Listener
		{
			get => GetPropertyValue<CHandle<ItemInSlotCallback>>();
			set => SetPropertyValue<CHandle<ItemInSlotCallback>>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ItemInSlotPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
