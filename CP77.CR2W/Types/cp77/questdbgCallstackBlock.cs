using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questdbgCallstackBlock : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CUInt64 Id { get; set; }
		[Ordinal(1)]  [RED("parentId")] public CUInt64 ParentId { get; set; }

		public questdbgCallstackBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
