using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShadowCascadeConfig : CVariable
	{
		[Ordinal(0)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(1)] [RED("filterSize")] public CFloat FilterSize { get; set; }
		[Ordinal(2)] [RED("blendRange")] public CFloat BlendRange { get; set; }
		[Ordinal(3)] [RED("biasOffset")] public CFloat BiasOffset { get; set; }

		public ShadowCascadeConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
