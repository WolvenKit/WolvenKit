using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animIAnimBreakpoint : CVariable
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }

		public animIAnimBreakpoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
