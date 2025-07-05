using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCpoPickableItem : gameObject
	{
		[Ordinal(36)] 
		[RED("itemIDToEquip")] 
		public TweakDBID ItemIDToEquip
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(37)] 
		[RED("quickSlotID")] 
		public CInt32 QuickSlotID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameCpoPickableItem()
		{
			QuickSlotID = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
