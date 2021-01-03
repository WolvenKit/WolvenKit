using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaTypeChangedNotification : redEvent
	{
		[Ordinal(0)]  [RED("area")] public wCHandle<SecurityAreaControllerPS> Area { get; set; }
		[Ordinal(1)]  [RED("currentType")] public CEnum<ESecurityAreaType> CurrentType { get; set; }
		[Ordinal(2)]  [RED("previousType")] public CEnum<ESecurityAreaType> PreviousType { get; set; }

		public SecurityAreaTypeChangedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
