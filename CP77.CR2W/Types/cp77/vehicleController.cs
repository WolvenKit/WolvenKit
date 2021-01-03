using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleController : gameComponent
	{
		[Ordinal(0)]  [RED("alarmCurve")] public CName AlarmCurve { get; set; }
		[Ordinal(1)]  [RED("alarmTime")] public CFloat AlarmTime { get; set; }

		public vehicleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
