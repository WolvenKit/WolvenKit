using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatPoolSpentPrereqListener : BaseStatPoolPrereqListener
	{
		[Ordinal(0)]  [RED("overallSpentValue")] public CFloat OverallSpentValue { get; set; }
		[Ordinal(1)]  [RED("state")] public wCHandle<StatPoolSpentPrereqState> State { get; set; }

		public StatPoolSpentPrereqListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
