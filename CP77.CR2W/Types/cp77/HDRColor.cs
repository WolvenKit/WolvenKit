using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta(EREDMetaInfo.REDStruct)]
	public class HDRColor : CVariable
	{
		[Ordinal(0)]  [RED("Alpha")] public CFloat Alpha { get; set; }
		[Ordinal(1)]  [RED("Blue")] public CFloat Blue { get; set; }
		[Ordinal(2)]  [RED("Green")] public CFloat Green { get; set; }
		[Ordinal(3)]  [RED("Red")] public CFloat Red { get; set; }

		public HDRColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
