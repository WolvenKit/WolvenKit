using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProficiencyTabButtonController : TabButtonController
	{
		[Ordinal(18)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("isToggledState")] 
		public CBool IsToggledState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ProficiencyTabButtonController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
