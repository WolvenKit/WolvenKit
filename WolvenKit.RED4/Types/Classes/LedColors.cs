using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LedColors : RedBaseClass
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

		public LedColors()
		{
			Off = new() { Color = new() };
			Red = new() { Color = new() };
			Green = new() { Color = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
