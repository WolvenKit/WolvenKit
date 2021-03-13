using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineData : CVariable
	{
		[Ordinal(0)] [RED("id")] public CRUID Id { get; set; }
		[Ordinal(1)] [RED("text")] public CString Text { get; set; }
		[Ordinal(2)] [RED("type")] public CEnum<scnDialogLineType> Type { get; set; }
		[Ordinal(3)] [RED("speaker")] public wCHandle<gameObject> Speaker { get; set; }
		[Ordinal(4)] [RED("speakerName")] public CString SpeakerName { get; set; }
		[Ordinal(5)] [RED("isPersistent")] public CBool IsPersistent { get; set; }
		[Ordinal(6)] [RED("duration")] public CFloat Duration { get; set; }

		public scnDialogLineData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
