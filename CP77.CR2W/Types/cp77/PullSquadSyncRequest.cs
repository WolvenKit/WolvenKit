using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PullSquadSyncRequest : AIAIEvent
	{
		[Ordinal(2)] [RED("squadType")] public CEnum<AISquadType> SquadType { get; set; }

		public PullSquadSyncRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
