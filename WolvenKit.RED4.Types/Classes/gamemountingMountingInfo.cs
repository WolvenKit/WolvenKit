using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemountingMountingInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("childId")] 
		public entEntityID ChildId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("parentId")] 
		public entEntityID ParentId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("slotId")] 
		public gamemountingMountingSlotId SlotId
		{
			get => GetPropertyValue<gamemountingMountingSlotId>();
			set => SetPropertyValue<gamemountingMountingSlotId>(value);
		}

		public gamemountingMountingInfo()
		{
			ChildId = new();
			ParentId = new();
			SlotId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
