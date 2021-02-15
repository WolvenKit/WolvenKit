using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnSceneTime : CVariable
	{
		[Ordinal(0)] [RED("stu")] public CUInt32 Stu { get; set; }

		public scnSceneTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
