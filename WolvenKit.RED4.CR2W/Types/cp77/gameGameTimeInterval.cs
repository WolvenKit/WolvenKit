using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGameTimeInterval : CVariable
	{
		[Ordinal(0)] [RED("begin")] public GameTime Begin { get; set; }
		[Ordinal(1)] [RED("end")] public GameTime End { get; set; }
		[Ordinal(2)] [RED("ignoreDays")] public CBool IgnoreDays { get; set; }

		public gameGameTimeInterval(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
