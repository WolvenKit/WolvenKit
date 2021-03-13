using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyle : CVariable
	{
		[Ordinal(0)] [RED("styleID")] public CName StyleID { get; set; }
		[Ordinal(1)] [RED("state")] public CName State { get; set; }
		[Ordinal(2)] [RED("properties")] public CArray<inkStyleProperty> Properties { get; set; }

		public inkStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
