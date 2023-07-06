using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LedColors_SensorDevice : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("off")] 
		public ScriptLightSettings Off
		{
			get => GetPropertyValue<ScriptLightSettings>();
			set => SetPropertyValue<ScriptLightSettings>(value);
		}

		[Ordinal(1)] 
		[RED("red")] 
		public ScriptLightSettings Red
		{
			get => GetPropertyValue<ScriptLightSettings>();
			set => SetPropertyValue<ScriptLightSettings>(value);
		}

		[Ordinal(2)] 
		[RED("green")] 
		public ScriptLightSettings Green
		{
			get => GetPropertyValue<ScriptLightSettings>();
			set => SetPropertyValue<ScriptLightSettings>(value);
		}

		[Ordinal(3)] 
		[RED("blue")] 
		public ScriptLightSettings Blue
		{
			get => GetPropertyValue<ScriptLightSettings>();
			set => SetPropertyValue<ScriptLightSettings>(value);
		}

		[Ordinal(4)] 
		[RED("yellow")] 
		public ScriptLightSettings Yellow
		{
			get => GetPropertyValue<ScriptLightSettings>();
			set => SetPropertyValue<ScriptLightSettings>(value);
		}

		[Ordinal(5)] 
		[RED("white")] 
		public ScriptLightSettings White
		{
			get => GetPropertyValue<ScriptLightSettings>();
			set => SetPropertyValue<ScriptLightSettings>(value);
		}

		public LedColors_SensorDevice()
		{
			Off = new ScriptLightSettings { Color = new CColor() };
			Red = new ScriptLightSettings { Color = new CColor() };
			Green = new ScriptLightSettings { Color = new CColor() };
			Blue = new ScriptLightSettings { Color = new CColor() };
			Yellow = new ScriptLightSettings { Color = new CColor() };
			White = new ScriptLightSettings { Color = new CColor() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
