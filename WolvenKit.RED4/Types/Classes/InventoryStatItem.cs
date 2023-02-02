using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryStatItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("label")] 
		public CWeakHandle<inkTextWidget> Label
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CWeakHandle<inkTextWidget> Value
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		public InventoryStatItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
