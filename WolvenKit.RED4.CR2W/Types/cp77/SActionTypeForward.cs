using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SActionTypeForward : CVariable
	{
		[Ordinal(0)] [RED("qHack")] public CBool QHack { get; set; }
		[Ordinal(1)] [RED("techie")] public CBool Techie { get; set; }
		[Ordinal(2)] [RED("master")] public CBool Master { get; set; }

		public SActionTypeForward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
