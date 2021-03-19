using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Hotkey : IScriptable
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

		public Hotkey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
