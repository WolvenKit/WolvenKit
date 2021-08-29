using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animDangleConstraint_SimulationSingleBone : animDangleConstraint_Simulation
	{
		private animTransformIndex _dangleBone;

		[Ordinal(13)] 
		[RED("dangleBone")] 
		public animTransformIndex DangleBone
		{
			get => GetProperty(ref _dangleBone);
			set => SetProperty(ref _dangleBone, value);
		}
	}
}
