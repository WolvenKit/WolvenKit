using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadFearEvent : redEvent
	{
		[Ordinal(0)] [RED("player")] public CBool Player { get; set; }
		[Ordinal(1)] [RED("phase")] public CInt32 Phase { get; set; }

		public SpreadFearEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
