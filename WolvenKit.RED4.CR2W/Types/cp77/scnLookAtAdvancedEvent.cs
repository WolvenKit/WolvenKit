using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtAdvancedEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("advancedData")] public scnLookAtAdvancedEventData AdvancedData { get; set; }

		public scnLookAtAdvancedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
