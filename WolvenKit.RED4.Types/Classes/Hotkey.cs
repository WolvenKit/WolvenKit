using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Hotkey : IScriptable
	{
		private CEnum<gameEHotkey> _hotkey;
		private gameItemID _itemID;
		private CArray<CEnum<gamedataItemType>> _scope;

		[Ordinal(0)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey_
		{
			get => GetProperty(ref _hotkey);
			set => SetProperty(ref _hotkey, value);
		}

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(2)] 
		[RED("scope")] 
		public CArray<CEnum<gamedataItemType>> Scope
		{
			get => GetProperty(ref _scope);
			set => SetProperty(ref _scope, value);
		}
	}
}
