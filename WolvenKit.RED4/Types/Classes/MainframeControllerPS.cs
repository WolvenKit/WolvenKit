using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MainframeControllerPS : BaseAnimatedDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("factName")] 
		public ComputerQuickHackData FactName
		{
			get => GetPropertyValue<ComputerQuickHackData>();
			set => SetPropertyValue<ComputerQuickHackData>(value);
		}

		public MainframeControllerPS()
		{
			FactName = new ComputerQuickHackData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
