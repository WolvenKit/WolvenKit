using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathPointUserDataEntry : CVariable
	{
		[Ordinal(0)] [RED("userData")] public CHandle<navLocomotionPathPointUserData> UserData { get; set; }
		[Ordinal(1)] [RED("nextUserData")] public CUInt32 NextUserData { get; set; }

		public navLocomotionPathPointUserDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
