using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDropItemFromSlot_NodeTypeParams : CVariable
	{
		private gameEntityReference _objectRef;
		private TweakDBID _slotId;
		private CBool _useGravity;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotId", cr2w, this);
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

		[Ordinal(2)] 
		[RED("useGravity")] 
		public CBool UseGravity
		{
			get
			{
				if (_useGravity == null)
				{
					_useGravity = (CBool) CR2WTypeManager.Create("Bool", "useGravity", cr2w, this);
				}
				return _useGravity;
			}
			set
			{
				if (_useGravity == value)
				{
					return;
				}
				_useGravity = value;
				PropertySet(this);
			}
		}

		public questDropItemFromSlot_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
