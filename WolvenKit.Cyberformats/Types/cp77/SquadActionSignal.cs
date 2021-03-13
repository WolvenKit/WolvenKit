using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SquadActionSignal : gameTaggedSignalUserData
	{
		[Ordinal(1)] [RED("squadActionName")] public CName SquadActionName { get; set; }
		[Ordinal(2)] [RED("squadVerb")] public CEnum<EAISquadVerb> SquadVerb { get; set; }

		public SquadActionSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
