using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Intercom : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(95)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(96)] 
		[RED("distractionSound")] 
		public CName DistractionSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public Intercom()
		{
			ControllerTypeName = "IntercomController";
			ShortGlitchDelayID = new gameDelayID();
			DistractionSound = "dev_radio_ditraction_glitching";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
