using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnLookAtAdvancedEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("advancedData")] public scnLookAtAdvancedEventData AdvancedData { get; set; }

		public scnLookAtAdvancedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
