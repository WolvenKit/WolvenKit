using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkInputIconMappingJSON : CVariable
	{
		[Ordinal(0)]  [RED("hold")] public CBool Hold { get; set; }
		[Ordinal(1)]  [RED("id")] public CName Id { get; set; }
		[Ordinal(2)]  [RED("part")] public CName Part { get; set; }

		public inkInputIconMappingJSON(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
