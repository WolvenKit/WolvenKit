using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityGateLockControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("entranceToken")] public entEntityID EntranceToken { get; set; }
		[Ordinal(1)]  [RED("isLeaving")] public CBool IsLeaving { get; set; }
		[Ordinal(2)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(3)]  [RED("tresspasserList")] public CArray<TrespasserEntry> TresspasserList { get; set; }

		public SecurityGateLockControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
