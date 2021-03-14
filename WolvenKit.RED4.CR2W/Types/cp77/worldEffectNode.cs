using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEffectNode : worldNode
	{
		[Ordinal(4)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(5)] [RED("streamingDistanceOverride")] public CFloat StreamingDistanceOverride { get; set; }

		public worldEffectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
