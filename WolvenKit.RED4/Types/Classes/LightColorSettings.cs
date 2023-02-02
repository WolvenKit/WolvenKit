using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LightColorSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("light")] 
		public worldWorldGlobalLightParameters Light
		{
			get => GetPropertyValue<worldWorldGlobalLightParameters>();
			set => SetPropertyValue<worldWorldGlobalLightParameters>(value);
		}

		public LightColorSettings()
		{
			Enable = true;
			Light = new() { Unit = Enums.ELightUnit.LU_Lux };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
