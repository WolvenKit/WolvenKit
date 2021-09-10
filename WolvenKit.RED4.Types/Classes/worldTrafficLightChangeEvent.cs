using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLightChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("lightColor")] 
		public CEnum<worldTrafficLightColor> LightColor
		{
			get => GetPropertyValue<CEnum<worldTrafficLightColor>>();
			set => SetPropertyValue<CEnum<worldTrafficLightColor>>(value);
		}
	}
}
