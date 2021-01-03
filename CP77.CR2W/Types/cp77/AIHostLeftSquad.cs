using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIHostLeftSquad : AIAIEvent
	{
		[Ordinal(0)]  [RED("squadInterface")] public wCHandle<AISquadScriptInterface> SquadInterface { get; set; }

		public AIHostLeftSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
