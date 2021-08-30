using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReflectorSFX : VendingMachineSFX
	{
		private CName _distraction;
		private CName _turnOn;
		private CName _turnOff;

		[Ordinal(2)] 
		[RED("distraction")] 
		public CName Distraction
		{
			get => GetProperty(ref _distraction);
			set => SetProperty(ref _distraction, value);
		}

		[Ordinal(3)] 
		[RED("turnOn")] 
		public CName TurnOn
		{
			get => GetProperty(ref _turnOn);
			set => SetProperty(ref _turnOn, value);
		}

		[Ordinal(4)] 
		[RED("turnOff")] 
		public CName TurnOff
		{
			get => GetProperty(ref _turnOff);
			set => SetProperty(ref _turnOff, value);
		}

		public ReflectorSFX()
		{
			_distraction = "dev_reflector_distraction";
			_turnOn = "dev_reflector_turn_on_loop";
			_turnOff = "dev_reflector_turn_on_loop_stop";
		}
	}
}
