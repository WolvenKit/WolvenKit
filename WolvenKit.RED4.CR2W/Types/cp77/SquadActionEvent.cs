using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SquadActionEvent : redEvent
	{
		[Ordinal(0)] [RED("squadActionName")] public CName SquadActionName { get; set; }
		[Ordinal(1)] [RED("squadVerb")] public CEnum<EAISquadVerb> SquadVerb { get; set; }

		public SquadActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
