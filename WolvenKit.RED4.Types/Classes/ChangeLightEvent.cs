using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeLightEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("settings")] 
		public ScriptLightSettings Settings
		{
			get => GetPropertyValue<ScriptLightSettings>();
			set => SetPropertyValue<ScriptLightSettings>(value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("curve")] 
		public CName Curve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("loop")] 
		public CBool Loop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ChangeLightEvent()
		{
			Settings = new() { Color = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
