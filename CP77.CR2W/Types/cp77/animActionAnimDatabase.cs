using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase : CResource
	{
		[Ordinal(0)]  [RED("rows")] public CArray<animActionAnimDatabase_DatabaseRow> Rows { get; set; }

		public animActionAnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
