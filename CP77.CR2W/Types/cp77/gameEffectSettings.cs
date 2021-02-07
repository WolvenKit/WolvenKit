using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectSettings : CVariable
	{
		[Ordinal(0)]  [RED("advancedTargetHandling")] public CBool AdvancedTargetHandling { get; set; }
		[Ordinal(1)]  [RED("synchronousProcessingForPlayer")] public CBool SynchronousProcessingForPlayer { get; set; }
		[Ordinal(2)]  [RED("forceSynchronousProcessing")] public CBool ForceSynchronousProcessing { get; set; }
		[Ordinal(3)]  [RED("tempExecuteOnlyOnce")] public CBool TempExecuteOnlyOnce { get; set; }

		public gameEffectSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
