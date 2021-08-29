using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioDeviceStateSettings : RedBaseClass
	{
		private CName _powerRestoredSound;
		private CName _powerCutSound;
		private CName _turnOnSound;
		private CName _turnOffSound;
		private CName _breakingSound;

		[Ordinal(0)] 
		[RED("powerRestoredSound")] 
		public CName PowerRestoredSound
		{
			get => GetProperty(ref _powerRestoredSound);
			set => SetProperty(ref _powerRestoredSound, value);
		}

		[Ordinal(1)] 
		[RED("powerCutSound")] 
		public CName PowerCutSound
		{
			get => GetProperty(ref _powerCutSound);
			set => SetProperty(ref _powerCutSound, value);
		}

		[Ordinal(2)] 
		[RED("turnOnSound")] 
		public CName TurnOnSound
		{
			get => GetProperty(ref _turnOnSound);
			set => SetProperty(ref _turnOnSound, value);
		}

		[Ordinal(3)] 
		[RED("turnOffSound")] 
		public CName TurnOffSound
		{
			get => GetProperty(ref _turnOffSound);
			set => SetProperty(ref _turnOffSound, value);
		}

		[Ordinal(4)] 
		[RED("breakingSound")] 
		public CName BreakingSound
		{
			get => GetProperty(ref _breakingSound);
			set => SetProperty(ref _breakingSound, value);
		}
	}
}
