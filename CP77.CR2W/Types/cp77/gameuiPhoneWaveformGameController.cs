using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneWaveformGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("measurementsCount")] public CInt32 MeasurementsCount { get; set; }
		[Ordinal(1)]  [RED("measurementsIntreval")] public CFloat MeasurementsIntreval { get; set; }

		public gameuiPhoneWaveformGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
