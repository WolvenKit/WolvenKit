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
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(2)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get => GetProperty(ref _hotkey);
			set => SetProperty(ref _hotkey, value);
		}

		[Ordinal(3)] 
		[RED("requestType")] 
		public CEnum<EHotkeyRequestType> RequestType
		{
			get => GetProperty(ref _requestType);
			set => SetProperty(ref _requestType, value);
		}

		public HotkeyAssignmentRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
