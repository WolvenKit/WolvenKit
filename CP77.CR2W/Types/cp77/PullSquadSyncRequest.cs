using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PullSquadSyncRequest : AIAIEvent
	{
		[Ordinal(0)]  [RED("squadType")] public CEnum<AISquadType> SquadType { get; set; }

		public PullSquadSyncRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
