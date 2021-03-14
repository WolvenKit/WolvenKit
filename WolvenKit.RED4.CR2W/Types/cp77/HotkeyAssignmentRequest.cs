using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeyAssignmentRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _itemID;
		private CEnum<gameEHotkey> _hotkey;
		private CEnum<EHotkeyRequestType> _requestType;

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get
			{
				if (_hotkey == null)
				{
					_hotkey = (CEnum<gameEHotkey>) CR2WTypeManager.Create("gameEHotkey", "hotkey", cr2w, this);
				}
				return _hotkey;
			}
			set
			{
				if (_hotkey == value)
				{
					return;
				}
				_hotkey = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("requestType")] 
		public CEnum<EHotkeyRequestType> RequestType
		{
			get
			{
				if (_requestType == null)
				{
					_requestType = (CEnum<EHotkeyRequestType>) CR2WTypeManager.Create("EHotkeyRequestType", "requestType", cr2w, this);
				}
				return _requestType;
			}
			set
			{
				if (_requestType == value)
				{
					return;
				}
				_requestType = value;
				PropertySet(this);
			}
		}

		public HotkeyAssignmentRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
