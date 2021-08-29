using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MainframeControllerPS : BaseAnimatedDeviceControllerPS
	{
		private ComputerQuickHackData _factName;

		[Ordinal(109)] 
		[RED("factName")] 
		public ComputerQuickHackData FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}
	}
}
