using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAnimationSetupExtensionComponent : entIComponent
	{
		[Ordinal(0)]  [RED("animations")] public animAnimSetup Animations { get; set; }
		[Ordinal(1)]  [RED("controlBinding")] public CHandle<entAnimationControlBinding> ControlBinding { get; set; }

		public entAnimationSetupExtensionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
