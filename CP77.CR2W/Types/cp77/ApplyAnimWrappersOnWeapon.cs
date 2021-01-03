using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ApplyAnimWrappersOnWeapon : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("ownerPosition")] public Vector4 OwnerPosition { get; set; }
		[Ordinal(3)]  [RED("refOwner")] public wCHandle<gamedataAIActionTarget_Record> RefOwner { get; set; }
		[Ordinal(4)]  [RED("wrapperName")] public CName WrapperName { get; set; }

		public ApplyAnimWrappersOnWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
