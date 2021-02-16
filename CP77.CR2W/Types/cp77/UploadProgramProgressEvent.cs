using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UploadProgramProgressEvent : redEvent
	{
		[Ordinal(0)] [RED("state")] public CEnum<EUploadProgramState> State { get; set; }
		[Ordinal(1)] [RED("progressBarType")] public CEnum<EProgressBarType> ProgressBarType { get; set; }
		[Ordinal(2)] [RED("progressBarContext")] public CEnum<EProgressBarContext> ProgressBarContext { get; set; }
		[Ordinal(3)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(4)] [RED("iconRecord")] public wCHandle<gamedataChoiceCaptionIconPart_Record> IconRecord { get; set; }
		[Ordinal(5)] [RED("action")] public CHandle<ScriptableDeviceAction> Action { get; set; }
		[Ordinal(6)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(7)] [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }

		public UploadProgramProgressEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
