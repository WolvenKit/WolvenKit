using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnGameplayActionEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("gameplayActionData")] public CHandle<scnIGameplayActionData> GameplayActionData { get; set; }
		[Ordinal(1)]  [RED("performer")] public scnPerformerId Performer { get; set; }

		public scnGameplayActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
