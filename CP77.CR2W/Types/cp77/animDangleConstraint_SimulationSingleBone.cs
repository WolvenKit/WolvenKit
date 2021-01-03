using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationSingleBone : animDangleConstraint_Simulation
	{
		[Ordinal(0)]  [RED("dangleBone")] public animTransformIndex DangleBone { get; set; }

		public animDangleConstraint_SimulationSingleBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
