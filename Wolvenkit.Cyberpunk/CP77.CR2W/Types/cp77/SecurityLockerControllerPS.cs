using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityLockerControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("isStoringPlayerEquipement")] public CBool IsStoringPlayerEquipement { get; set; }
		[Ordinal(1)]  [RED("securityLockerProperties")] public SecurityLockerProperties SecurityLockerProperties { get; set; }

		public SecurityLockerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
