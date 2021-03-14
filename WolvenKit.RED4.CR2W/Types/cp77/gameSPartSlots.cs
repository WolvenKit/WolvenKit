using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSPartSlots : CVariable
	{
		private CEnum<gameESlotState> _status;
		private gameItemID _installedPart;
		private TweakDBID _slotID;
		private gameInnerItemData _innerItemData;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<gameESlotState> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<gameESlotState>) CR2WTypeManager.Create("gameESlotState", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("installedPart")] 
		public gameItemID InstalledPart
		{
			get
			{
				if (_installedPart == null)
				{
					_installedPart = (gameItemID) CR2WTypeManager.Create("gameItemID", "installedPart", cr2w, this);
				}
				return _installedPart;
			}
			set
			{
				if (_installedPart == value)
				{
					return;
				}
				_installedPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("innerItemData")] 
		public gameInnerItemData InnerItemData
		{
			get
			{
				if (_innerItemData == null)
				{
					_innerItemData = (gameInnerItemData) CR2WTypeManager.Create("gameInnerItemData", "innerItemData", cr2w, this);
				}
				return _innerItemData;
			}
			set
			{
				if (_innerItemData == value)
				{
					return;
				}
				_innerItemData = value;
				PropertySet(this);
			}
		}

		public gameSPartSlots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
