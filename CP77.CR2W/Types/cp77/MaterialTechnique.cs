using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MaterialTechnique : CVariable
	{
		[Ordinal(0)] [RED("passes")] public CArray<MaterialPass> Passes { get; set; }
		[Ordinal(1)] [RED("featureFlagsEnabledMask")] public FeatureFlagsMask FeatureFlagsEnabledMask { get; set; }
		[Ordinal(2)] [RED("streamsToBind")] public CUInt32 StreamsToBind { get; set; }

		public MaterialTechnique(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
