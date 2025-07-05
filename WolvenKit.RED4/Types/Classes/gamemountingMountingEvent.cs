using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemountingMountingEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("request")] 
		public CHandle<gamemountingMountingRequest> Request
		{
			get => GetPropertyValue<CHandle<gamemountingMountingRequest>>();
			set => SetPropertyValue<CHandle<gamemountingMountingRequest>>(value);
		}

		[Ordinal(1)] 
		[RED("relationship")] 
		public gamemountingMountingRelationship Relationship
		{
			get => GetPropertyValue<gamemountingMountingRelationship>();
			set => SetPropertyValue<gamemountingMountingRelationship>(value);
		}

		public gamemountingMountingEvent()
		{
			Relationship = new gamemountingMountingRelationship { SlotId = new gamemountingMountingSlotId() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
