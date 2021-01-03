using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SelectorRevalutionBreak : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(1)]  [RED("reevaluationDuration")] public CFloat ReevaluationDuration { get; set; }

		public SelectorRevalutionBreak(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
