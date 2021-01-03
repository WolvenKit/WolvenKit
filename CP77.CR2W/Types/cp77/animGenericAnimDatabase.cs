using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animGenericAnimDatabase : CResource
	{
		[Ordinal(0)]  [RED("rows")] public CArray<animGenericAnimDatabase_DatabaseRow> Rows { get; set; }

		public animGenericAnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
