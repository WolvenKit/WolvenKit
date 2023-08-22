using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Hotkey : IScriptable
	{
		[Ordinal(0)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey_
		{
			get => GetPropertyValue<CEnum<gameEHotkey>>();
			set => SetPropertyValue<CEnum<gameEHotkey>>(value);
		}

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("scope")] 
		public CArray<CEnum<gamedataItemType>> Scope
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		public Hotkey()
		{
			ItemID = new gameItemID();
			Scope = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
