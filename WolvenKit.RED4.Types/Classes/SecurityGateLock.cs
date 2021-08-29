using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityGateLock : InteractiveDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _enteringArea;
		private CHandle<gameStaticTriggerAreaComponent> _centeredArea;
		private CHandle<gameStaticTriggerAreaComponent> _leavingArea;

		[Ordinal(97)] 
		[RED("enteringArea")] 
		public CHandle<gameStaticTriggerAreaComponent> EnteringArea
		{
			get => GetProperty(ref _enteringArea);
			set => SetProperty(ref _enteringArea, value);
		}

		[Ordinal(98)] 
		[RED("centeredArea")] 
		public CHandle<gameStaticTriggerAreaComponent> CenteredArea
		{
			get => GetProperty(ref _centeredArea);
			set => SetProperty(ref _centeredArea, value);
		}

		[Ordinal(99)] 
		[RED("leavingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> LeavingArea
		{
			get => GetProperty(ref _leavingArea);
			set => SetProperty(ref _leavingArea, value);
		}
	}
}
