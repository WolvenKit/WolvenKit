using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkStyle : CVariable
	{
		[Ordinal(0)]  [RED("properties")] public CArray<inkStyleProperty> Properties { get; set; }
		[Ordinal(1)]  [RED("state")] public CName State { get; set; }
		[Ordinal(2)]  [RED("styleID")] public CName StyleID { get; set; }

		public inkStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
