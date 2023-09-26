using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseSensorOwnerChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newOwnerId")] 
		public entEntityID NewOwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public senseSensorOwnerChangedEvent()
		{
			NewOwnerId = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
