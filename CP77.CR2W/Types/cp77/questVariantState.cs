using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questVariantState : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("show")] public CBool Show { get; set; }

		public questVariantState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
