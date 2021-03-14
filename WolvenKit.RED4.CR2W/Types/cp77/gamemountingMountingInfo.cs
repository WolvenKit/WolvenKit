using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingInfo : CVariable
	{
		private entEntityID _childId;
		private entEntityID _parentId;
		private gamemountingMountingSlotId _slotId;

		[Ordinal(0)] 
		[RED("childId")] 
		public entEntityID ChildId
		{
			get
			{
				if (_childId == null)
				{
					_childId = (entEntityID) CR2WTypeManager.Create("entEntityID", "childId", cr2w, this);
				}
				return _childId;
			}
			set
			{
				if (_childId == value)
				{
					return;
				}
				_childId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parentId")] 
		public entEntityID ParentId
		{
			get
			{
				if (_parentId == null)
				{
					_parentId = (entEntityID) CR2WTypeManager.Create("entEntityID", "parentId", cr2w, this);
				}
				return _parentId;
			}
			set
			{
				if (_parentId == value)
				{
					return;
				}
				_parentId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public gamemountingMountingInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
