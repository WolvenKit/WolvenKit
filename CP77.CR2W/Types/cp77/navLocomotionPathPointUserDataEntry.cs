using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathPointUserDataEntry : CVariable
	{
		[Ordinal(0)]  [RED("nextUserData")] public CUInt32 NextUserData { get; set; }
		[Ordinal(1)]  [RED("userData")] public CHandle<navLocomotionPathPointUserData> UserData { get; set; }

		public navLocomotionPathPointUserDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
