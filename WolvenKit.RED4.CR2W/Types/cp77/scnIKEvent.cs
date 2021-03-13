using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnIKEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("ikData")] public scnIKEventData IkData { get; set; }

		public scnIKEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
