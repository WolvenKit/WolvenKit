using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LeaveCoverImmediately : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("completeOnLeave")] public CBool CompleteOnLeave { get; set; }
		[Ordinal(1)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(2)]  [RED("timeStamp")] public CFloat TimeStamp { get; set; }
		[Ordinal(3)]  [RED("triggered")] public CBool Triggered { get; set; }

		public LeaveCoverImmediately(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
