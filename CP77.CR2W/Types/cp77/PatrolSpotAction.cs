using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PatrolSpotAction : TweakAIActionSmartComposite
	{
		[Ordinal(0)]  [RED("patrolAction")] public CHandle<AIArgumentMapping> PatrolAction { get; set; }

		public PatrolSpotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
