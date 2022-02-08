using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCpoPickableItem : gameObject
	{
		[Ordinal(40)] 
		[RED("itemIDToEquip")] 
		public TweakDBID ItemIDToEquip
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(41)] 
		[RED("quickSlotID")] 
		public CInt32 QuickSlotID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameCpoPickableItem()
		{
			QuickSlotID = -1;
		}
	}
}
