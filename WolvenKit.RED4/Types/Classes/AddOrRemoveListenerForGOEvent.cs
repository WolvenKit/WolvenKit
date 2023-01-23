using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddOrRemoveListenerForGOEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<GameObjectListener> Listener
		{
			get => GetPropertyValue<CHandle<GameObjectListener>>();
			set => SetPropertyValue<CHandle<GameObjectListener>>(value);
		}

		[Ordinal(1)] 
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AddOrRemoveListenerForGOEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
