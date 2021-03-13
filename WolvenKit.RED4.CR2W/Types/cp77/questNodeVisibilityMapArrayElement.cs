using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questNodeVisibilityMapArrayElement : CVariable
	{
		[Ordinal(0)] [RED("globalNodeRef")] public worldGlobalNodeRef GlobalNodeRef { get; set; }
		[Ordinal(1)] [RED("visible")] public CBool Visible { get; set; }

		public questNodeVisibilityMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
