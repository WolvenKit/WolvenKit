using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetControllerStimSource : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("investigateData")] public stimInvestigateData InvestigateData { get; set; }

		public SetControllerStimSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
