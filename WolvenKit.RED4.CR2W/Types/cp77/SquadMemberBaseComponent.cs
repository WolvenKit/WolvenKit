using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SquadMemberBaseComponent : gameSquadMemberComponent
	{
		[Ordinal(4)] [RED("baseSquadRecord")] public wCHandle<gamedataAISquadParams_Record> BaseSquadRecord { get; set; }

		public SquadMemberBaseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
