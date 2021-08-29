using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceBaseBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _actionWidgetsData;
		private gamebbScriptID_Variant _deviceWidgetsData;
		private gamebbScriptID_Bool _uIupdate;
		private gamebbScriptID_Variant _breadCrumbElement;
		private gamebbScriptID_Variant _glitchData;
		private gamebbScriptID_Bool _uI_InteractivityBlocked;
		private gamebbScriptID_Bool _isInvestigated;

		[Ordinal(0)] 
		[RED("ActionWidgetsData")] 
		public gamebbScriptID_Variant ActionWidgetsData
		{
			get => GetProperty(ref _actionWidgetsData);
			set => SetProperty(ref _actionWidgetsData, value);
		}

		[Ordinal(1)] 
		[RED("DeviceWidgetsData")] 
		public gamebbScriptID_Variant DeviceWidgetsData
		{
			get => GetProperty(ref _deviceWidgetsData);
			set => SetProperty(ref _deviceWidgetsData, value);
		}

		[Ordinal(2)] 
		[RED("UIupdate")] 
		public gamebbScriptID_Bool UIupdate
		{
			get => GetProperty(ref _uIupdate);
			set => SetProperty(ref _uIupdate, value);
		}

		[Ordinal(3)] 
		[RED("BreadCrumbElement")] 
		public gamebbScriptID_Variant BreadCrumbElement
		{
			get => GetProperty(ref _breadCrumbElement);
			set => SetProperty(ref _breadCrumbElement, value);
		}

		[Ordinal(4)] 
		[RED("GlitchData")] 
		public gamebbScriptID_Variant GlitchData
		{
			get => GetProperty(ref _glitchData);
			set => SetProperty(ref _glitchData, value);
		}

		[Ordinal(5)] 
		[RED("UI_InteractivityBlocked")] 
		public gamebbScriptID_Bool UI_InteractivityBlocked
		{
			get => GetProperty(ref _uI_InteractivityBlocked);
			set => SetProperty(ref _uI_InteractivityBlocked, value);
		}

		[Ordinal(6)] 
		[RED("IsInvestigated")] 
		public gamebbScriptID_Bool IsInvestigated
		{
			get => GetProperty(ref _isInvestigated);
			set => SetProperty(ref _isInvestigated, value);
		}
	}
}
