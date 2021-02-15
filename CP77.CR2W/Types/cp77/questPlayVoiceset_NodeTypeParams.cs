using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPlayVoiceset_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)] [RED("voicesetName")] public CName VoicesetName { get; set; }
		[Ordinal(3)] [RED("useVoicesetSystem")] public CBool UseVoicesetSystem { get; set; }
		[Ordinal(4)] [RED("playOnlyGrunt")] public CBool PlayOnlyGrunt { get; set; }
		[Ordinal(5)] [RED("overridingVoiceoverContext")] public CEnum<locVoiceoverContext> OverridingVoiceoverContext { get; set; }
		[Ordinal(6)] [RED("overrideVoiceoverExpression")] public CBool OverrideVoiceoverExpression { get; set; }
		[Ordinal(7)] [RED("overridingVoiceoverExpression")] public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression { get; set; }
		[Ordinal(8)] [RED("overrideVisualStyle")] public CBool OverrideVisualStyle { get; set; }
		[Ordinal(9)] [RED("overridingVisualStyle")] public CEnum<scnDialogLineVisualStyle> OverridingVisualStyle { get; set; }

		public questPlayVoiceset_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
