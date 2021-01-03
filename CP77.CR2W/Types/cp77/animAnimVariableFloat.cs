using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableFloat : animAnimVariable
	{
		[Ordinal(0)]  [RED("default")] public CFloat Default { get; set; }
		[Ordinal(1)]  [RED("max")] public CFloat Max { get; set; }
		[Ordinal(2)]  [RED("min")] public CFloat Min { get; set; }
		[Ordinal(3)]  [RED("value")] public CFloat Value { get; set; }

		public animAnimVariableFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
