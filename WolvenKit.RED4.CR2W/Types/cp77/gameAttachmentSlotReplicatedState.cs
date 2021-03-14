using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotReplicatedState : CVariable
	{
		private TweakDBID _slotID;
		private gameItemID _activeItemID;
		private CBool _hasItemObject;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activeItemID")] 
		public gameItemID ActiveItemID
		{
			get
			{
				if (_activeItemID == null)
				{
					_activeItemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "activeItemID", cr2w, this);
				}
				return _activeItemID;
			}
			set
			{
				if (_activeItemID == value)
				{
					return;
				}
				_activeItemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hasItemObject")] 
		public CBool HasItemObject
		{
			get
			{
				if (_hasItemObject == null)
				{
					_hasItemObject = (CBool) CR2WTypeManager.Create("Bool", "hasItemObject", cr2w, this);
				}
				return _hasItemObject;
			}
			set
			{
				if (_hasItemObject == value)
				{
					return;
				}
				_hasItemObject = value;
				PropertySet(this);
			}
		}

		public gameAttachmentSlotReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
