using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimationSetupExtensionComponent : entIComponent
	{
		[Ordinal(3)] [RED("animations")] public animAnimSetup Animations { get; set; }
		[Ordinal(4)] [RED("controlBinding")] public CHandle<entAnimationControlBinding> ControlBinding { get; set; }

		public entAnimationSetupExtensionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
