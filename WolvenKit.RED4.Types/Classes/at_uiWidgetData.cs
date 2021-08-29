using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class at_uiWidgetData : RedBaseClass
	{
		private CString _widgetATID;
		private CEnum<inkELayerType> _layerType;
		private CName _parentGameController;

		[Ordinal(0)] 
		[RED("widgetATID")] 
		public CString WidgetATID
		{
			get => GetProperty(ref _widgetATID);
			set => SetProperty(ref _widgetATID, value);
		}

		[Ordinal(1)] 
		[RED("layerType")] 
		public CEnum<inkELayerType> LayerType
		{
			get => GetProperty(ref _layerType);
			set => SetProperty(ref _layerType, value);
		}

		[Ordinal(2)] 
		[RED("parentGameController")] 
		public CName ParentGameController
		{
			get => GetProperty(ref _parentGameController);
			set => SetProperty(ref _parentGameController, value);
		}
	}
}
