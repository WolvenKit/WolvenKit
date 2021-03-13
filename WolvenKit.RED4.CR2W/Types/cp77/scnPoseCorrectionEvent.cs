using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPoseCorrectionEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(7)] [RED("poseCorrectionGroup")] public animPoseCorrectionGroup PoseCorrectionGroup { get; set; }

		public scnPoseCorrectionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
