using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarmSetup : CVariable
	{
		[Ordinal(0)] [RED("useSound")] public CBool UseSound { get; set; }
		[Ordinal(1)] [RED("alarmSound")] public CName AlarmSound { get; set; }

		public SecurityAlarmSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
