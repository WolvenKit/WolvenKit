using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CheckAnimSetTags : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("animsetTagToCompare")] public CArray<CName> AnimsetTagToCompare { get; set; }

		public CheckAnimSetTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
