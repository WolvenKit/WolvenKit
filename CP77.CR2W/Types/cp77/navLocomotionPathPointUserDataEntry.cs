using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathPointUserDataEntry : CVariable
	{
		[Ordinal(0)] [RED("userData")] public CHandle<navLocomotionPathPointUserData> UserData { get; set; }
		[Ordinal(1)] [RED("nextUserData")] public CUInt32 NextUserData { get; set; }

		public navLocomotionPathPointUserDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
