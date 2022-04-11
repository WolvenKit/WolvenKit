using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemountingMountingRelationship : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("otherMountableType")] 
		public CEnum<gameMountingObjectType> OtherMountableType
		{
			get => GetPropertyValue<CEnum<gameMountingObjectType>>();
			set => SetPropertyValue<CEnum<gameMountingObjectType>>(value);
		}

		[Ordinal(1)] 
		[RED("otherObject")] 
		public CWeakHandle<gameObject> OtherObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("relationshipType")] 
		public CEnum<gameMountingRelationshipType> RelationshipType
		{
			get => GetPropertyValue<CEnum<gameMountingRelationshipType>>();
			set => SetPropertyValue<CEnum<gameMountingRelationshipType>>(value);
		}

		[Ordinal(3)] 
		[RED("slotId")] 
		public gamemountingMountingSlotId SlotId
		{
			get => GetPropertyValue<gamemountingMountingSlotId>();
			set => SetPropertyValue<gamemountingMountingSlotId>(value);
		}

		public gamemountingMountingRelationship()
		{
			SlotId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
