using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
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
