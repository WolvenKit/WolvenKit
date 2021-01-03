using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatConstant : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("value")] public CFloat Value { get; set; }

		public animAnimNode_FloatConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
