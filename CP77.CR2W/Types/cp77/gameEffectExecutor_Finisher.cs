using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_Finisher : gameEffectExecutor
	{
		[Ordinal(0)]  [RED("allowCameraMovement")] public CBool AllowCameraMovement { get; set; }
		[Ordinal(1)]  [RED("alwaysUseEntryAnims")] public CBool AlwaysUseEntryAnims { get; set; }
		[Ordinal(2)]  [RED("finisherScenarios")] public CArray<CHandle<gameIFinisherScenario>> FinisherScenarios { get; set; }

		public gameEffectExecutor_Finisher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
