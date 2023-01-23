using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GOGProfileLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("gogMenuState")] 
		public CEnum<EGOGMenuState> GogMenuState
		{
			get => GetPropertyValue<CEnum<EGOGMenuState>>();
			set => SetPropertyValue<CEnum<EGOGMenuState>>(value);
		}

		public GOGProfileLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
