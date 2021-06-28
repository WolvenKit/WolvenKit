using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryInventoryItem : CVariable
	{
		private CString _friendlyName;
		private CString _localizedName;
		private gameItemID _itemID;
		private CInt32 _quality;
		private CEnum<gamedataItemType> _itemType;
		private CBool _iconic;
		private CInt32 _itemLevel;
		private CBool _isSilenced;

		[Ordinal(0)] 
		[RED("friendlyName")] 
		public CString FriendlyName
		{
			get => GetProperty(ref _friendlyName);
			set => SetProperty(ref _friendlyName, value);
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(2)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(3)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(4)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(5)] 
		[RED("iconic")] 
		public CBool Iconic
		{
			get => GetProperty(ref _iconic);
			set => SetProperty(ref _iconic, value);
		}

		[Ordinal(6)] 
		[RED("itemLevel")] 
		public CInt32 ItemLevel
		{
			get => GetProperty(ref _itemLevel);
			set => SetProperty(ref _itemLevel, value);
		}

		[Ordinal(7)] 
		[RED("isSilenced")] 
		public CBool IsSilenced
		{
			get => GetProperty(ref _isSilenced);
			set => SetProperty(ref _isSilenced, value);
		}

		public gameTelemetryInventoryItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
