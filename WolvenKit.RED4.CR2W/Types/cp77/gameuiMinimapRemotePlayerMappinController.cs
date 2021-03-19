using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapRemotePlayerMappinController : gameuiBaseMinimapMappinController
	{
		private inkWidgetReference _rootWidget;
		private inkWidgetReference _shapeWidget;
		private inkWidgetReference _dataWidget;
		private wCHandle<gamemappinsRemotePlayerMappin> _playerMappin;

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
		public wCHandle<gamemappinsRemotePlayerMappin> PlayerMappin
		{
			get => GetProperty(ref _playerMappin);
			set => SetProperty(ref _playerMappin, value);
		}

		public gameuiMinimapRemotePlayerMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
