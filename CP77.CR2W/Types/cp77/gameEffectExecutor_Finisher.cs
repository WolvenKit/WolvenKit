using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_Finisher : gameEffectExecutor
	{
		[Ordinal(0)]  [RED("finisherScenarios")] public CArray<CHandle<gameIFinisherScenario>> FinisherScenarios { get; set; }
		[Ordinal(1)]  [RED("alwaysUseEntryAnims")] public CBool AlwaysUseEntryAnims { get; set; }
		[Ordinal(2)]  [RED("allowCameraMovement")] public CBool AllowCameraMovement { get; set; }

		public gameEffectExecutor_Finisher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
