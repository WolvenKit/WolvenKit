using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SPerk : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gamedataPerkType> Type { get; set; }
		[Ordinal(1)] [RED("currLevel")] public CInt32 CurrLevel { get; set; }

		public SPerk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
