using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("isSoundStopped")] public CBool IsSoundStopped { get; set; }

		public VehicleRadioLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
