using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDistantLightsNode : worldNode
	{
		[Ordinal(4)] [RED("data")] public raRef<CDistantLightsResource> Data { get; set; }

		public worldDistantLightsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
