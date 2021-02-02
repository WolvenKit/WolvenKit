using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animGenericAnimDatabase_DatabaseRow : CVariable
	{
		[Ordinal(0)]  [RED("inputValues")] public CArray<CInt32> InputValues { get; set; }
		[Ordinal(1)]  [RED("animationData")] public animGenericAnimDatabase_AnimationData AnimationData { get; set; }

		public animGenericAnimDatabase_DatabaseRow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
