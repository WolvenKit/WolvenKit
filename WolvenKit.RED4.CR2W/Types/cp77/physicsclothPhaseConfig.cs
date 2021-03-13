using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothPhaseConfig : CVariable
	{
		[Ordinal(0)] [RED("stiffness")] public CFloat Stiffness { get; set; }
		[Ordinal(1)] [RED("stiffnessMultiplier")] public CFloat StiffnessMultiplier { get; set; }
		[Ordinal(2)] [RED("compressionLimit")] public CFloat CompressionLimit { get; set; }
		[Ordinal(3)] [RED("stretchLimit")] public CFloat StretchLimit { get; set; }

		public physicsclothPhaseConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
