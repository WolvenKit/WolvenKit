using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickHackMappinController : gameuiInteractionMappinController
	{
		private inkWidgetReference _bar;
		private inkTextWidgetReference _header;
		private inkImageWidgetReference _iconWidgetActive;
		private CWeakHandle<inkWidget> _rootWidget;
		private CWeakHandle<gamemappinsIMappin> _mappin;
		private CHandle<GameplayRoleMappinData> _data;

		[Ordinal(11)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(12)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(13)] 
		[RED("iconWidgetActive")] 
		public inkImageWidgetReference IconWidgetActive
		{
			get => GetProperty(ref _iconWidgetActive);
			set => SetProperty(ref _iconWidgetActive, value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(15)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsIMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<GameplayRoleMappinData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
