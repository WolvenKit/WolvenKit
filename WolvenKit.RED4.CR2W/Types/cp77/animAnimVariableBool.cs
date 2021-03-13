using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableBool : animAnimVariable
	{
		[Ordinal(2)] [RED("value")] public CBool Value { get; set; }
		[Ordinal(3)] [RED("default")] public CBool Default { get; set; }

		public animAnimVariableBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
