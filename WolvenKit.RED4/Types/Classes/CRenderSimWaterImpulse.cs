using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CRenderSimWaterImpulse : IDynamicTextureGenerator
	{
		[Ordinal(0)] 
		[RED("simulationSpeed")] 
		public CFloat SimulationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CRenderSimWaterImpulse()
		{
			SimulationSpeed = 24.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
