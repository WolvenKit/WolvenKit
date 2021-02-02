using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workIWorkspotCondition : ISerializable
	{
		[Ordinal(0)]  [RED("expectedResult")] public CEnum<workWorkspotLogic> ExpectedResult { get; set; }
		[Ordinal(1)]  [RED("equals")] public CBool Equals { get; set; }

		public workIWorkspotCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
