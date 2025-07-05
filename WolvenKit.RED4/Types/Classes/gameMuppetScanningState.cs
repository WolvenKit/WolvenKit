using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetScanningState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameMuppetScanningState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
