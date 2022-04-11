using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldRainEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("rainIntensity")] 
		public CEnum<worldRainIntensity> RainIntensity
		{
			get => GetPropertyValue<CEnum<worldRainIntensity>>();
			set => SetPropertyValue<CEnum<worldRainIntensity>>(value);
		}

		public worldRainEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
