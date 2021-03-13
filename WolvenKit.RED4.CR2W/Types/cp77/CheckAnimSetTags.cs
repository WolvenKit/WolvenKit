using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckAnimSetTags : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("animsetTagToCompare")] public CArray<CName> AnimsetTagToCompare { get; set; }

		public CheckAnimSetTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
