using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatPoolSpentPrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("listener")] public CHandle<BaseStatPoolPrereqListener> Listener { get; set; }
		[Ordinal(1)]  [RED("neededValue")] public CFloat NeededValue { get; set; }

		public StatPoolSpentPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
