using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CallOffReactionAction : SquadTask
	{
		[Ordinal(0)]  [RED("squadActionName")] public CEnum<EAISquadAction> SquadActionName { get; set; }

		public CallOffReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
