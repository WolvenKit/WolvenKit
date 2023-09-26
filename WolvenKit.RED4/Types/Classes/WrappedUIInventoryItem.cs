using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WrappedUIInventoryItem : IScriptable
	{
		[Ordinal(0)] 
		[RED("Item")] 
		public CWeakHandle<UIInventoryItem> Item
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(1)] 
		[RED("AdditionalData")] 
		public CHandle<IScriptable> AdditionalData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public WrappedUIInventoryItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
