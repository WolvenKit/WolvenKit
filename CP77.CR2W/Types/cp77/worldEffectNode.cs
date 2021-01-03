using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldEffectNode : worldNode
	{
		[Ordinal(0)]  [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(1)]  [RED("streamingDistanceOverride")] public CFloat StreamingDistanceOverride { get; set; }

		public worldEffectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
