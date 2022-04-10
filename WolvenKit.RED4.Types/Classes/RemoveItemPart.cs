using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveItemPart : gameScriptableSystemRequest
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
		[RED("slotToEmpty")] 
		public TweakDBID SlotToEmpty
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public RemoveItemPart()
		{
			BaseItem = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
