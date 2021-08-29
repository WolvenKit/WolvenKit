using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLightChangeEvent : redEvent
	{
		private CEnum<worldTrafficLightColor> _lightColor;

		[Ordinal(0)] 
		[RED("lightColor")] 
		public CEnum<worldTrafficLightColor> LightColor
		{
			get => GetProperty(ref _lightColor);
			set => SetProperty(ref _lightColor, value);
		}
	}
}
