using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleDrawerEmitterOrientation : IParticleDrawer
	{
		[Ordinal(1)] 
		[RED("coordinateSystem")] 
		public EulerAngles CoordinateSystem
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(2)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleDrawerEmitterOrientation()
		{
			CoordinateSystem = new EulerAngles();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
