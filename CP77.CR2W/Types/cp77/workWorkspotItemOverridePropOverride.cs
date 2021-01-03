using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workWorkspotItemOverridePropOverride : CVariable
	{
		[Ordinal(0)]  [RED("newItemId")] public CName NewItemId { get; set; }
		[Ordinal(1)]  [RED("prevItemId")] public CName PrevItemId { get; set; }

		public workWorkspotItemOverridePropOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
