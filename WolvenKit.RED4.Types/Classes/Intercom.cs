using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Intercom : InteractiveDevice
	{
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CName _distractionSound;

		[Ordinal(97)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(98)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(99)] 
		[RED("distractionSound")] 
		public CName DistractionSound
		{
			get => GetProperty(ref _distractionSound);
			set => SetProperty(ref _distractionSound, value);
		}

		public Intercom()
		{
			_distractionSound = "dev_radio_ditraction_glitching";
		}
	}
}
