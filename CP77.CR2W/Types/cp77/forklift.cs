using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class forklift : InteractiveDevice
	{
		[Ordinal(93)] [RED("animFeature")] public CHandle<AnimFeature_ForkliftDevice> AnimFeature { get; set; }
		[Ordinal(94)] [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(95)] [RED("isPlayerUnder")] public CBool IsPlayerUnder { get; set; }
		[Ordinal(96)] [RED("cargoBox")] public CHandle<entPhysicalMeshComponent> CargoBox { get; set; }

		public forklift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
