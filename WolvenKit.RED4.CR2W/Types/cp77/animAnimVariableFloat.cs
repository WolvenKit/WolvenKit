using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableFloat : animAnimVariable
	{
		[Ordinal(2)] [RED("value")] public CFloat Value { get; set; }
		[Ordinal(3)] [RED("default")] public CFloat Default { get; set; }
		[Ordinal(4)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(5)] [RED("max")] public CFloat Max { get; set; }

		public animAnimVariableFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
