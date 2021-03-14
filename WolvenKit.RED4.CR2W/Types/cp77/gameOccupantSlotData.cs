using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameOccupantSlotData : CVariable
	{
		private CName _slotName;
		private CName _syncAnimationTag;
		private rRef<workWorkspotResource> _workSpotResource;
		private Vector4 _exitOffsetFromSlot;
		private CEnum<gameMountingSlotRole> _role;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("syncAnimationTag")] 
		public CName SyncAnimationTag
		{
			get
			{
				if (_syncAnimationTag == null)
				{
					_syncAnimationTag = (CName) CR2WTypeManager.Create("CName", "syncAnimationTag", cr2w, this);
				}
				return _syncAnimationTag;
			}
			set
			{
				if (_syncAnimationTag == value)
				{
					return;
				}
				_syncAnimationTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("workSpotResource")] 
		public rRef<workWorkspotResource> WorkSpotResource
		{
			get
			{
				if (_workSpotResource == null)
				{
					_workSpotResource = (rRef<workWorkspotResource>) CR2WTypeManager.Create("rRef:workWorkspotResource", "workSpotResource", cr2w, this);
				}
				return _workSpotResource;
			}
			set
			{
				if (_workSpotResource == value)
				{
					return;
				}
				_workSpotResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("exitOffsetFromSlot")] 
		public Vector4 ExitOffsetFromSlot
		{
			get
			{
				if (_exitOffsetFromSlot == null)
				{
					_exitOffsetFromSlot = (Vector4) CR2WTypeManager.Create("Vector4", "exitOffsetFromSlot", cr2w, this);
				}
				return _exitOffsetFromSlot;
			}
			set
			{
				if (_exitOffsetFromSlot == value)
				{
					return;
				}
				_exitOffsetFromSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("role")] 
		public CEnum<gameMountingSlotRole> Role
		{
			get
			{
				if (_role == null)
				{
					_role = (CEnum<gameMountingSlotRole>) CR2WTypeManager.Create("gameMountingSlotRole", "role", cr2w, this);
				}
				return _role;
			}
			set
			{
				if (_role == value)
				{
					return;
				}
				_role = value;
				PropertySet(this);
			}
		}

		public gameOccupantSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
