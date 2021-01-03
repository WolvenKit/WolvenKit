using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCompiledNode : worldNode
	{
		[Ordinal(0)]  [RED("aabb")] public Box Aabb { get; set; }

		public worldTrafficCompiledNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
