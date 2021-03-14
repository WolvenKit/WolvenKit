using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerMountPuppet_NodeType : questIEntityManager_NodeType
	{
		private gameEntityReference _parentRef;
		private gameEntityReference _childRef;
		private CBool _isParentPlayer;
		private CName _slotName;
		private CBool _assign;
		private CBool _isInstant;
		private CEnum<gamePSMBodyCarryingStyle> _forcedCarryStyle;
		private CBool _removePitchRollRotation;

		[Ordinal(0)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get
			{
				if (_parentRef == null)
				{
					_parentRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "parentRef", cr2w, this);
				}
				return _parentRef;
			}
			set
			{
				if (_parentRef == value)
				{
					return;
				}
				_parentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("childRef")] 
		public gameEntityReference ChildRef
		{
			get
			{
				if (_childRef == null)
				{
					_childRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "childRef", cr2w, this);
				}
				return _childRef;
			}
			set
			{
				if (_childRef == value)
				{
					return;
				}
				_childRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isParentPlayer")] 
		public CBool IsParentPlayer
		{
			get
			{
				if (_isParentPlayer == null)
				{
					_isParentPlayer = (CBool) CR2WTypeManager.Create("Bool", "isParentPlayer", cr2w, this);
				}
				return _isParentPlayer;
			}
			set
			{
				if (_isParentPlayer == value)
				{
					return;
				}
				_isParentPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("assign")] 
		public CBool Assign
		{
			get
			{
				if (_assign == null)
				{
					_assign = (CBool) CR2WTypeManager.Create("Bool", "assign", cr2w, this);
				}
				return _assign;
			}
			set
			{
				if (_assign == value)
				{
					return;
				}
				_assign = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get
			{
				if (_isInstant == null)
				{
					_isInstant = (CBool) CR2WTypeManager.Create("Bool", "isInstant", cr2w, this);
				}
				return _isInstant;
			}
			set
			{
				if (_isInstant == value)
				{
					return;
				}
				_isInstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forcedCarryStyle")] 
		public CEnum<gamePSMBodyCarryingStyle> ForcedCarryStyle
		{
			get
			{
				if (_forcedCarryStyle == null)
				{
					_forcedCarryStyle = (CEnum<gamePSMBodyCarryingStyle>) CR2WTypeManager.Create("gamePSMBodyCarryingStyle", "forcedCarryStyle", cr2w, this);
				}
				return _forcedCarryStyle;
			}
			set
			{
				if (_forcedCarryStyle == value)
				{
					return;
				}
				_forcedCarryStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("removePitchRollRotation")] 
		public CBool RemovePitchRollRotation
		{
			get
			{
				if (_removePitchRollRotation == null)
				{
					_removePitchRollRotation = (CBool) CR2WTypeManager.Create("Bool", "removePitchRollRotation", cr2w, this);
				}
				return _removePitchRollRotation;
			}
			set
			{
				if (_removePitchRollRotation == value)
				{
					return;
				}
				_removePitchRollRotation = value;
				PropertySet(this);
			}
		}

		public questEntityManagerMountPuppet_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
