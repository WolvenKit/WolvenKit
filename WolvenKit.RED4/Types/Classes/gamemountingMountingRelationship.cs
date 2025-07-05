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
		[RED("otherMountableSubType")] 
		public CEnum<gameMountingObjectSubType> OtherMountableSubType
		{
			get => GetPropertyValue<CEnum<gameMountingObjectSubType>>();
			set => SetPropertyValue<CEnum<gameMountingObjectSubType>>(value);
		}

		[Ordinal(2)] 
		[RED("otherObject")] 
		public CWeakHandle<gameObject> OtherObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("relationshipType")] 
		public CEnum<gameMountingRelationshipType> RelationshipType
		{
			get => GetPropertyValue<CEnum<gameMountingRelationshipType>>();
			set => SetPropertyValue<CEnum<gameMountingRelationshipType>>(value);
		}

		[Ordinal(4)] 
		[RED("slotId")] 
		public gamemountingMountingSlotId SlotId
		{
			get => GetPropertyValue<gamemountingMountingSlotId>();
			set => SetPropertyValue<gamemountingMountingSlotId>(value);
		}

		public gamemountingMountingRelationship()
		{
			SlotId = new gamemountingMountingSlotId();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
