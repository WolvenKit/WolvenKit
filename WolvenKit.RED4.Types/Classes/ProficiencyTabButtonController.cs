using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProficiencyTabButtonController : TabButtonController
	{
		private CHandle<inkanimProxy> _proxy;
		private CBool _isToggledState;

		[Ordinal(18)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetProperty(ref _proxy);
			set => SetProperty(ref _proxy, value);
		}

		[Ordinal(19)] 
		[RED("isToggledState")] 
		public CBool IsToggledState
		{
			get => GetProperty(ref _isToggledState);
			set => SetProperty(ref _isToggledState, value);
		}
	}
}
