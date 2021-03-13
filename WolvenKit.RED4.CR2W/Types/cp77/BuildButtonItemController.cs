using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BuildButtonItemController : inkButtonDpadSupportedController
	{
		[Ordinal(26)] [RED("associatedBuild")] public CEnum<gamedataBuildType> AssociatedBuild { get; set; }

		public BuildButtonItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
