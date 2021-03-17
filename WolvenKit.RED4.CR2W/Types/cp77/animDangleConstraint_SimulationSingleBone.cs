using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationSingleBone : animDangleConstraint_Simulation
	{
		private animTransformIndex _dangleBone;

		[Ordinal(13)] 
		[RED("dangleBone")] 
		public animTransformIndex DangleBone
		{
			get => GetProperty(ref _dangleBone);
			set => SetProperty(ref _dangleBone, value);
		}

		public animDangleConstraint_SimulationSingleBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
