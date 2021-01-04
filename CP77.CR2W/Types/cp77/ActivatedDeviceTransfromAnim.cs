using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTransfromAnim : InteractiveDevice
	{
		[Ordinal(0)]  [RED("animationState")] public CInt32 AnimationState { get; set; }

		public ActivatedDeviceTransfromAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
