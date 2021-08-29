using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetrunnerControlPanelControllerPS : BasicDistractionDeviceControllerPS
	{
		private ComputerQuickHackData _factQuickHackSetup;
		private CBool _quickhackPerformed;

		[Ordinal(109)] 
		[RED("factQuickHackSetup")] 
		public ComputerQuickHackData FactQuickHackSetup
		{
			get => GetProperty(ref _factQuickHackSetup);
			set => SetProperty(ref _factQuickHackSetup, value);
		}

		[Ordinal(110)] 
		[RED("quickhackPerformed")] 
		public CBool QuickhackPerformed
		{
			get => GetProperty(ref _quickhackPerformed);
			set => SetProperty(ref _quickhackPerformed, value);
		}
	}
}
