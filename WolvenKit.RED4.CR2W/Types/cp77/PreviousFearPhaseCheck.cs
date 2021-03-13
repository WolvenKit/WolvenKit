using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreviousFearPhaseCheck : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("fearPhase")] public CInt32 FearPhase { get; set; }

		public PreviousFearPhaseCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
