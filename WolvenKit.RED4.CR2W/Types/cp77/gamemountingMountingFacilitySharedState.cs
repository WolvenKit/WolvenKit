using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingFacilitySharedState : ISerializable
	{
		private CArray<wCHandle<entEntity>> _children;
		private CArray<wCHandle<entEntity>> _parents;
		private CArray<gamemountingMountingSlotId> _slotIds;
		private CArray<CEnum<gameMountingObjectType>> _parentTypes;
		private CArray<CEnum<gameMountingObjectType>> _childTypes;

		[Ordinal(0)] 
		[RED("children")] 
		public CArray<wCHandle<entEntity>> Children
		{
			get
			{
				if (_children == null)
				{
					_children = (CArray<wCHandle<entEntity>>) CR2WTypeManager.Create("array:whandle:entEntity", "children", cr2w, this);
				}
				return _children;
			}
			set
			{
				if (_children == value)
				{
					return;
				}
				_children = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parents")] 
		public CArray<wCHandle<entEntity>> Parents
		{
			get
			{
				if (_parents == null)
				{
					_parents = (CArray<wCHandle<entEntity>>) CR2WTypeManager.Create("array:whandle:entEntity", "parents", cr2w, this);
				}
				return _parents;
			}
			set
			{
				if (_parents == value)
				{
					return;
				}
				_parents = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotIds")] 
		public CArray<gamemountingMountingSlotId> SlotIds
		{
			get
			{
				if (_slotIds == null)
				{
					_slotIds = (CArray<gamemountingMountingSlotId>) CR2WTypeManager.Create("array:gamemountingMountingSlotId", "slotIds", cr2w, this);
				}
				return _slotIds;
			}
			set
			{
				if (_slotIds == value)
				{
					return;
				}
				_slotIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("parentTypes")] 
		public CArray<CEnum<gameMountingObjectType>> ParentTypes
		{
			get
			{
				if (_parentTypes == null)
				{
					_parentTypes = (CArray<CEnum<gameMountingObjectType>>) CR2WTypeManager.Create("array:gameMountingObjectType", "parentTypes", cr2w, this);
				}
				return _parentTypes;
			}
			set
			{
				if (_parentTypes == value)
				{
					return;
				}
				_parentTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("childTypes")] 
		public CArray<CEnum<gameMountingObjectType>> ChildTypes
		{
			get
			{
				if (_childTypes == null)
				{
					_childTypes = (CArray<CEnum<gameMountingObjectType>>) CR2WTypeManager.Create("array:gameMountingObjectType", "childTypes", cr2w, this);
				}
				return _childTypes;
			}
			set
			{
				if (_childTypes == value)
				{
					return;
				}
				_childTypes = value;
				PropertySet(this);
			}
		}

		public gamemountingMountingFacilitySharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
