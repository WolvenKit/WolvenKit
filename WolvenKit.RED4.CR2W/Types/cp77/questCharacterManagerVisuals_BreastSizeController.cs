using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_BreastSizeController : questICharacterManagerVisuals_NodeSubType
	{
		[Ordinal(0)] [RED("bodyGroupName")] public CName BodyGroupName { get; set; }
		[Ordinal(1)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(2)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)] [RED("customizedSize")] public CBool CustomizedSize { get; set; }

		public questCharacterManagerVisuals_BreastSizeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
