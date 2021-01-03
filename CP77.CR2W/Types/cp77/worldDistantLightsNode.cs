using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDistantLightsNode : worldNode
	{
		[Ordinal(0)]  [RED("data")] public raRef<CDistantLightsResource> Data { get; set; }

		public worldDistantLightsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
