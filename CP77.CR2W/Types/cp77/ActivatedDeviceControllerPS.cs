using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)]  [RED("animationSetup")] public ActivatedDeviceAnimSetup AnimationSetup { get; set; }
		[Ordinal(104)]  [RED("activatedDeviceSetup")] public ActivatedDeviceSetup ActivatedDeviceSetup { get; set; }
		[Ordinal(105)]  [RED("spiderbotInteractionLocationOverride")] public NodeRef SpiderbotInteractionLocationOverride { get; set; }
		[Ordinal(106)]  [RED("industrialArmAnimationOverride")] public CInt32 IndustrialArmAnimationOverride { get; set; }

		public ActivatedDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
