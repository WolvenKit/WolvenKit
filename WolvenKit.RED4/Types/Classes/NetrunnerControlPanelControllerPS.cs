using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetrunnerControlPanelControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("factQuickHackSetup")] 
		public ComputerQuickHackData FactQuickHackSetup
		{
			get => GetPropertyValue<ComputerQuickHackData>();
			set => SetPropertyValue<ComputerQuickHackData>(value);
		}

		[Ordinal(110)] 
		[RED("quickhackPerformed")] 
		public CBool QuickhackPerformed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NetrunnerControlPanelControllerPS()
		{
			FactQuickHackSetup = new ComputerQuickHackData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
