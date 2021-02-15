using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questStopWorkspot_NodeType : questIBehaviourManager_NodeType
	{
		[Ordinal(1)] [RED("allowCurrAnimToFinish")] public CBool AllowCurrAnimToFinish { get; set; }
		[Ordinal(2)] [RED("exitAnim")] public CName ExitAnim { get; set; }

		public questStopWorkspot_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
