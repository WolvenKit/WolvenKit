using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlayVideoEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("videoPath")] public CString VideoPath { get; set; }
		[Ordinal(7)] [RED("isPhoneCall")] public CBool IsPhoneCall { get; set; }
		[Ordinal(8)] [RED("forceFrameRate")] public CBool ForceFrameRate { get; set; }

		public scnPlayVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
