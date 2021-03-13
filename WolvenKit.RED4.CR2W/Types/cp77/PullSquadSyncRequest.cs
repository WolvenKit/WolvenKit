using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PullSquadSyncRequest : AIAIEvent
	{
		[Ordinal(2)] [RED("squadType")] public CEnum<AISquadType> SquadType { get; set; }

		public PullSquadSyncRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
