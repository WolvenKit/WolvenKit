using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemountingUnmountingEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("request")] 
		public CHandle<gamemountingUnmountingRequest> Request
		{
			get => GetPropertyValue<CHandle<gamemountingUnmountingRequest>>();
			set => SetPropertyValue<CHandle<gamemountingUnmountingRequest>>(value);
		}

		[Ordinal(1)] 
		[RED("relationship")] 
		public gamemountingMountingRelationship Relationship
		{
			get => GetPropertyValue<gamemountingMountingRelationship>();
			set => SetPropertyValue<gamemountingMountingRelationship>(value);
		}

		public gamemountingUnmountingEvent()
		{
			Relationship = new gamemountingMountingRelationship { SlotId = new gamemountingMountingSlotId() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
