using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CRenderSimWaterImpulse : IDynamicTextureGenerator
	{
		[Ordinal(0)] 
		[RED("resolution")] 
		public CInt32 Resolution
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("simulationSpeed")] 
		public CFloat SimulationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CRenderSimWaterImpulse()
		{
			Resolution = 1024;
			SimulationSpeed = 24.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
