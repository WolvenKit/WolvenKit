using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MainframeControllerPS : BaseAnimatedDeviceControllerPS
	{
		[Ordinal(112)] 
		[RED("factName")] 
		public ComputerQuickHackData FactName
		{
			get => GetPropertyValue<ComputerQuickHackData>();
			set => SetPropertyValue<ComputerQuickHackData>(value);
		}

		public MainframeControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
