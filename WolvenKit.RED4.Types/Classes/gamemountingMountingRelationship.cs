using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemountingMountingRelationship : RedBaseClass
	{
		private CEnum<gameMountingObjectType> _otherMountableType;
		private CWeakHandle<gameObject> _otherObject;
		private CEnum<gameMountingRelationshipType> _relationshipType;
		private gamemountingMountingSlotId _slotId;

		[Ordinal(0)] 
		[RED("otherMountableType")] 
		public CEnum<gameMountingObjectType> OtherMountableType
		{
			get => GetProperty(ref _otherMountableType);
			set => SetProperty(ref _otherMountableType, value);
		}

		[Ordinal(1)] 
		[RED("otherObject")] 
		public CWeakHandle<gameObject> OtherObject
		{
			get => GetProperty(ref _otherObject);
			set => SetProperty(ref _otherObject, value);
		}

		[Ordinal(2)] 
		[RED("relationshipType")] 
		public CEnum<gameMountingRelationshipType> RelationshipType
		{
			get => GetProperty(ref _relationshipType);
			set => SetProperty(ref _relationshipType, value);
		}

		[Ordinal(3)] 
		[RED("slotId")] 
		public gamemountingMountingSlotId SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}
	}
}
