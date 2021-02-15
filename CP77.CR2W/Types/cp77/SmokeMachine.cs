using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SmokeMachine : BasicDistractionDevice
	{
		[Ordinal(99)] [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }
		[Ordinal(100)] [RED("highLightActive")] public CBool HighLightActive { get; set; }
		[Ordinal(101)] [RED("entities")] public CArray<wCHandle<entEntity>> Entities { get; set; }

		public SmokeMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
