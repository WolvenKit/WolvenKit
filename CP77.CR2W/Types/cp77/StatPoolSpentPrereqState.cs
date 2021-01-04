using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatPoolSpentPrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("listener")] public CHandle<BaseStatPoolPrereqListener> Listener { get; set; }
		[Ordinal(1)]  [RED("neededValue")] public CFloat NeededValue { get; set; }

		public StatPoolSpentPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
