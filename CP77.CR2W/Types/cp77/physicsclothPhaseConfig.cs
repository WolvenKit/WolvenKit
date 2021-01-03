using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsclothPhaseConfig : CVariable
	{
		[Ordinal(0)]  [RED("compressionLimit")] public CFloat CompressionLimit { get; set; }
		[Ordinal(1)]  [RED("stiffness")] public CFloat Stiffness { get; set; }
		[Ordinal(2)]  [RED("stiffnessMultiplier")] public CFloat StiffnessMultiplier { get; set; }
		[Ordinal(3)]  [RED("stretchLimit")] public CFloat StretchLimit { get; set; }

		public physicsclothPhaseConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
