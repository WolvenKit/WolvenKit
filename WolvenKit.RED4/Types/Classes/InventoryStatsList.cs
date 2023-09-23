using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryStatsList : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("titleText")] 
		public CWeakHandle<inkTextWidget> TitleText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("containerWidget")] 
		public CWeakHandle<inkCompoundWidget> ContainerWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("widgtesList")] 
		public CArray<CWeakHandle<inkWidget>> WidgtesList
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		public InventoryStatsList()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
