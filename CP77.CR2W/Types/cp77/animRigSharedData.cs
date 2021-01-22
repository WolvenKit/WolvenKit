using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animRigSharedData : CResource
	{
		[Ordinal(0)]  [RED("ikSetups")] public CArray<CHandle<animIRigIkSetup>> IkSetups { get; set; }
		[Ordinal(1)]  [RED("parts")] public CArray<animRigPart> Parts { get; set; }

		public animRigSharedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
