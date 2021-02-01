using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OutlineData : CVariable
	{
		[Ordinal(0)]  [RED("outlineStrength")] public CFloat OutlineStrength { get; set; }
		[Ordinal(1)]  [RED("outlineType")] public CEnum<EOutlineType> OutlineType { get; set; }

		public OutlineData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
