using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class forklift : InteractiveDevice
	{
		[Ordinal(0)]  [RED("animFeature")] public CHandle<AnimFeature_ForkliftDevice> AnimFeature { get; set; }
		[Ordinal(1)]  [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(2)]  [RED("cargoBox")] public CHandle<entPhysicalMeshComponent> CargoBox { get; set; }
		[Ordinal(3)]  [RED("isPlayerUnder")] public CBool IsPlayerUnder { get; set; }

		public forklift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
