using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ShadowCascadeConfig : CVariable
	{
		[Ordinal(0)]  [RED("biasOffset")] public CFloat BiasOffset { get; set; }
		[Ordinal(1)]  [RED("blendRange")] public CFloat BlendRange { get; set; }
		[Ordinal(2)]  [RED("filterSize")] public CFloat FilterSize { get; set; }
		[Ordinal(3)]  [RED("range")] public CFloat Range { get; set; }

		public ShadowCascadeConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
