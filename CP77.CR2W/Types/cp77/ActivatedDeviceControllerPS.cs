using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("activatedDeviceSetup")] public ActivatedDeviceSetup ActivatedDeviceSetup { get; set; }
		[Ordinal(1)]  [RED("animationSetup")] public ActivatedDeviceAnimSetup AnimationSetup { get; set; }
		[Ordinal(2)]  [RED("industrialArmAnimationOverride")] public CInt32 IndustrialArmAnimationOverride { get; set; }
		[Ordinal(3)]  [RED("spiderbotInteractionLocationOverride")] public NodeRef SpiderbotInteractionLocationOverride { get; set; }

		public ActivatedDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
