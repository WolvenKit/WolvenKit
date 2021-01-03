using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSector : CResource
	{
		[Ordinal(0)]  [RED("category")] public CInt8 Category { get; set; }
		[Ordinal(1)]  [RED("externInplaceResource")] public raRef<worldStreamingSectorInplaceContent> ExternInplaceResource { get; set; }
		[Ordinal(2)]  [RED("level")] public CUInt8 Level { get; set; }
		[Ordinal(3)]  [RED("localInplaceResource")] public CArray<rRef<CResource>> LocalInplaceResource { get; set; }

		public worldStreamingSector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
