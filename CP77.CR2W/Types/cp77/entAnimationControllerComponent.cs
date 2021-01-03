using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entAnimationControllerComponent : entIComponent
	{
		[Ordinal(0)]  [RED("actionAnimDatabaseRef")] public rRef<animActionAnimDatabase> ActionAnimDatabaseRef { get; set; }
		[Ordinal(1)]  [RED("animDatabaseCollection")] public animAnimDatabaseCollection AnimDatabaseCollection { get; set; }
		[Ordinal(2)]  [RED("controlBinding")] public CHandle<entAnimationControlBinding> ControlBinding { get; set; }

		public entAnimationControllerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
