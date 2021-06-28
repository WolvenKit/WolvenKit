using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingRelationship : CVariable
	{
		private CEnum<gameMountingObjectType> _otherMountableType;
		private wCHandle<gameObject> _otherObject;
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
		public wCHandle<gameObject> OtherObject
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

		public gamemountingMountingRelationship(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
