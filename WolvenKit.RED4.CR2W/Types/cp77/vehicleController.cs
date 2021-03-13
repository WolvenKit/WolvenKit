using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleController : gameComponent
	{
		[Ordinal(4)] [RED("alarmCurve")] public CName AlarmCurve { get; set; }
		[Ordinal(5)] [RED("alarmTime")] public CFloat AlarmTime { get; set; }

		public vehicleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
