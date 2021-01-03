using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarmBreachResponse : ActionBool
	{
		[Ordinal(0)]  [RED("currentSecurityState")] public CEnum<ESecuritySystemState> CurrentSecurityState { get; set; }

		public SecurityAlarmBreachResponse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
