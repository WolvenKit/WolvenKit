using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Intercom : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(99)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(100)] 
		[RED("dialStartSound")] 
		public CName DialStartSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(101)] 
		[RED("dialStopSound")] 
		public CName DialStopSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(102)] 
		[RED("distractionStartSound")] 
		public CName DistractionStartSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(103)] 
		[RED("distractionStopSound")] 
		public CName DistractionStopSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(104)] 
		[RED("answeredSound")] 
		public CName AnsweredSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public Intercom()
		{
			ControllerTypeName = "IntercomController";
			ShortGlitchDelayID = new gameDelayID();
			DialStartSound = "dev_intercom_dial_start";
			DialStopSound = "dev_intercom_dial_stop";
			DistractionStartSound = "dev_intercom_distraction_start";
			DistractionStopSound = "dev_intercom_distraction_stop";
			AnsweredSound = "dev_intercom_answered";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
