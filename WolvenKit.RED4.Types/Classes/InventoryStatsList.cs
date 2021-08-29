using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryStatsList : inkWidgetLogicController
	{
		private CWeakHandle<inkTextWidget> _titleText;
		private CWeakHandle<inkCompoundWidget> _containerWidget;
		private CArray<CWeakHandle<inkWidget>> _widgtesList;

		[Ordinal(1)] 
		[RED("titleText")] 
		public CWeakHandle<inkTextWidget> TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(2)] 
		[RED("containerWidget")] 
		public CWeakHandle<inkCompoundWidget> ContainerWidget
		{
			get => GetProperty(ref _containerWidget);
			set => SetProperty(ref _containerWidget, value);
		}

		[Ordinal(3)] 
		[RED("widgtesList")] 
		public CArray<CWeakHandle<inkWidget>> WidgtesList
		{
			get => GetProperty(ref _widgtesList);
			set => SetProperty(ref _widgtesList, value);
		}
	}
}
