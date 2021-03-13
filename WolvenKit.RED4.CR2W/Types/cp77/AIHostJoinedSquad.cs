using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIHostJoinedSquad : AIAIEvent
	{
		[Ordinal(2)] [RED("squad")] public CName Squad { get; set; }

		public AIHostJoinedSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
