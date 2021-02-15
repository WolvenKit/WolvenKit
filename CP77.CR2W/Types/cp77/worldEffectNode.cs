using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldEffectNode : worldNode
	{
		[Ordinal(2)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(3)] [RED("streamingDistanceOverride")] public CFloat StreamingDistanceOverride { get; set; }

		public worldEffectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
