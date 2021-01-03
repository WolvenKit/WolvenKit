using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BoolInput : animAnimNode_BoolValue
	{
		[Ordinal(0)]  [RED("group")] public CName Group { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }

		public animAnimNode_BoolInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
