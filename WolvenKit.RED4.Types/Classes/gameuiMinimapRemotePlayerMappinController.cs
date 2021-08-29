using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMinimapRemotePlayerMappinController : gameuiBaseMinimapMappinController
	{
		private inkWidgetReference _rootWidget;
		private inkWidgetReference _shapeWidget;
		private inkWidgetReference _dataWidget;
		private CWeakHandle<gamemappinsRemotePlayerMappin> _playerMappin;

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public inkWidgetReference RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(15)] 
		[RED("shapeWidget")] 
		public inkWidgetReference ShapeWidget
		{
			get => GetProperty(ref _shapeWidget);
			set => SetProperty(ref _shapeWidget, value);
		}

		[Ordinal(16)] 
		[RED("dataWidget")] 
		public inkWidgetReference DataWidget
		{
			get => GetProperty(ref _dataWidget);
			set => SetProperty(ref _dataWidget, value);
		}

		[Ordinal(17)] 
		[RED("playerMappin")] 
		public CWeakHandle<gamemappinsRemotePlayerMappin> PlayerMappin
		{
			get => GetProperty(ref _playerMappin);
			set => SetProperty(ref _playerMappin, value);
		}
	}
}
