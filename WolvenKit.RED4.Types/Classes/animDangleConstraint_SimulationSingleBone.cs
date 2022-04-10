using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDangleConstraint_SimulationSingleBone : animDangleConstraint_Simulation
	{
		[Ordinal(13)] 
		[RED("dangleBone")] 
		public animTransformIndex DangleBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animDangleConstraint_SimulationSingleBone()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
