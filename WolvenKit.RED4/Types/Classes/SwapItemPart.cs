using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SwapItemPart : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("obj")] 
		public CWeakHandle<gameObject> Obj
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("baseItem")] 
		public gameItemID BaseItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("partToInstall")] 
		public gameItemID PartToInstall
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(3)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SwapItemPart()
		{
			BaseItem = new();
			PartToInstall = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
