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
			get
			{
				if (_otherMountableType == null)
				{
					_otherMountableType = (CEnum<gameMountingObjectType>) CR2WTypeManager.Create("gameMountingObjectType", "otherMountableType", cr2w, this);
				}
				return _otherMountableType;
			}
			set
			{
				if (_otherMountableType == value)
				{
					return;
				}
				_otherMountableType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("otherObject")] 
		public wCHandle<gameObject> OtherObject
		{
			get
			{
				if (_otherObject == null)
				{
					_otherObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "otherObject", cr2w, this);
				}
				return _otherObject;
			}
			set
			{
				if (_otherObject == value)
				{
					return;
				}
				_otherObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("relationshipType")] 
		public CEnum<gameMountingRelationshipType> RelationshipType
		{
			get
			{
				if (_relationshipType == null)
				{
					_relationshipType = (CEnum<gameMountingRelationshipType>) CR2WTypeManager.Create("gameMountingRelationshipType", "relationshipType", cr2w, this);
				}
				return _relationshipType;
			}
			set
			{
				if (_relationshipType == value)
				{
					return;
				}
				_relationshipType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("slotId")] 
		public gamemountingMountingSlotId SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (gamemountingMountingSlotId) CR2WTypeManager.Create("gamemountingMountingSlotId", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		public gamemountingMountingRelationship(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
