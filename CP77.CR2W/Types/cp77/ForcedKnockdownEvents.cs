using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ForcedKnockdownEvents : KnockdownEvents
	{
		[Ordinal(0)]  [RED("firstUpdate")] public CBool FirstUpdate { get; set; }

		public ForcedKnockdownEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
