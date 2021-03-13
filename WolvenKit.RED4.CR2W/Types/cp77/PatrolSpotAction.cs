using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PatrolSpotAction : TweakAIActionSmartComposite
	{
		[Ordinal(38)] [RED("patrolAction")] public CHandle<AIArgumentMapping> PatrolAction { get; set; }

		public PatrolSpotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
