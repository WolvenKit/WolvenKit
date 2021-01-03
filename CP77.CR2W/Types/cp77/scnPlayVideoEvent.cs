using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnPlayVideoEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("forceFrameRate")] public CBool ForceFrameRate { get; set; }
		[Ordinal(1)]  [RED("isPhoneCall")] public CBool IsPhoneCall { get; set; }
		[Ordinal(2)]  [RED("videoPath")] public CString VideoPath { get; set; }

		public scnPlayVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
