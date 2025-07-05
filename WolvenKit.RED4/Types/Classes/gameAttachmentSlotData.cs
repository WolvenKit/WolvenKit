using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttachmentSlotData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("itemObject")] 
		public CHandle<gameItemObject> ItemObject
		{
			get => GetPropertyValue<CHandle<gameItemObject>>();
			set => SetPropertyValue<CHandle<gameItemObject>>(value);
		}

		[Ordinal(2)] 
		[RED("activeItemID")] 
		public gameItemID ActiveItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(3)] 
		[RED("prevItemID")] 
		public gameItemID PrevItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(4)] 
		[RED("appearanceItemID")] 
		public gameItemID AppearanceItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gameAttachmentSlotData()
		{
			ActiveItemID = new gameItemID();
			PrevItemID = new gameItemID();
			AppearanceItemID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
