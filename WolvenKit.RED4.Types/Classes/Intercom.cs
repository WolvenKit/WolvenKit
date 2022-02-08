using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Intercom : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(98)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(99)] 
		[RED("distractionSound")] 
		public CName DistractionSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public Intercom()
		{
			ControllerTypeName = "IntercomController";
			ShortGlitchDelayID = new();
			DistractionSound = "dev_radio_ditraction_glitching";
		}
	}
}
