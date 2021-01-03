using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StimuliSquadActionEvent : senseBaseStimuliEvent
	{
		[Ordinal(0)]  [RED("squadActionName")] public CName SquadActionName { get; set; }
		[Ordinal(1)]  [RED("squadVerb")] public CEnum<EAISquadVerb> SquadVerb { get; set; }

		public StimuliSquadActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
