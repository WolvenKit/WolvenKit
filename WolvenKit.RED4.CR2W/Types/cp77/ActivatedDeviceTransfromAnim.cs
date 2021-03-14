using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTransfromAnim : InteractiveDevice
	{
		[Ordinal(93)] [RED("animationState")] public CInt32 AnimationState { get; set; }

		public ActivatedDeviceTransfromAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
