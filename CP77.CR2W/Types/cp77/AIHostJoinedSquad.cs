using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIHostJoinedSquad : AIAIEvent
	{
		[Ordinal(0)]  [RED("squad")] public CName Squad { get; set; }

		public AIHostJoinedSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
