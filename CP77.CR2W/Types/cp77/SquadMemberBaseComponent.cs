using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SquadMemberBaseComponent : gameSquadMemberComponent
	{
		[Ordinal(0)]  [RED("baseSquadRecord")] public wCHandle<gamedataAISquadParams_Record> BaseSquadRecord { get; set; }

		public SquadMemberBaseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
