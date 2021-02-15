using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnLookAtBodyPartPropertiesAdvanced : CVariable
	{
		[Ordinal(0)] [RED("bodyPartName")] public CName BodyPartName { get; set; }

		public scnLookAtBodyPartPropertiesAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
