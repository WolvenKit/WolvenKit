using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemountingMountingFacilitySharedState : ISerializable
	{
		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CWeakHandle<entEntity>> Children
		{
			get => GetPropertyValue<CArray<CWeakHandle<entEntity>>>();
			set => SetPropertyValue<CArray<CWeakHandle<entEntity>>>(value);
		}

		[Ordinal(1)] 
		[RED("parents")] 
		public CArray<CWeakHandle<entEntity>> Parents
		{
			get => GetPropertyValue<CArray<CWeakHandle<entEntity>>>();
			set => SetPropertyValue<CArray<CWeakHandle<entEntity>>>(value);
		}

		[Ordinal(2)] 
		[RED("slotIds")] 
		public CArray<gamemountingMountingSlotId> SlotIds
		{
			get => GetPropertyValue<CArray<gamemountingMountingSlotId>>();
			set => SetPropertyValue<CArray<gamemountingMountingSlotId>>(value);
		}

		[Ordinal(3)] 
		[RED("parentTypes")] 
		public CArray<CEnum<gameMountingObjectType>> ParentTypes
		{
			get => GetPropertyValue<CArray<CEnum<gameMountingObjectType>>>();
			set => SetPropertyValue<CArray<CEnum<gameMountingObjectType>>>(value);
		}

		[Ordinal(4)] 
		[RED("childTypes")] 
		public CArray<CEnum<gameMountingObjectType>> ChildTypes
		{
			get => GetPropertyValue<CArray<CEnum<gameMountingObjectType>>>();
			set => SetPropertyValue<CArray<CEnum<gameMountingObjectType>>>(value);
		}

		public gamemountingMountingFacilitySharedState()
		{
			Children = new();
			Parents = new();
			SlotIds = new();
			ParentTypes = new();
			ChildTypes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
