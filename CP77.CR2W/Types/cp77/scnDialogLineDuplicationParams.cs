using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineDuplicationParams : CVariable
	{
		[Ordinal(0)]  [RED("additionalSpeakerId")] public scnActorId AdditionalSpeakerId { get; set; }
		[Ordinal(1)]  [RED("executionTag")] public CUInt8 ExecutionTag { get; set; }
		[Ordinal(2)]  [RED("isHolocallSpeaker")] public CBool IsHolocallSpeaker { get; set; }

		public scnDialogLineDuplicationParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
