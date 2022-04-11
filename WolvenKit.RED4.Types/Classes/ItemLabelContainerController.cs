using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemLabelContainerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("items")] 
		public CArray<CWeakHandle<ItemLabelController>> Items
		{
			get => GetPropertyValue<CArray<CWeakHandle<ItemLabelController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ItemLabelController>>>(value);
		}

		public ItemLabelContainerController()
		{
			Items = new();
		}
	}
}
