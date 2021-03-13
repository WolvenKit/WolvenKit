using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineDuplicationParams : CVariable
	{
		[Ordinal(0)] [RED("executionTag")] public CUInt8 ExecutionTag { get; set; }
		[Ordinal(1)] [RED("additionalSpeakerId")] public scnActorId AdditionalSpeakerId { get; set; }
		[Ordinal(2)] [RED("isHolocallSpeaker")] public CBool IsHolocallSpeaker { get; set; }

		public scnDialogLineDuplicationParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
