using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RegisterLinkedCluekRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("linkedCluekData")] public LinkedFocusClueData LinkedCluekData { get; set; }
		[Ordinal(1)] [RED("forceUpdate")] public CBool ForceUpdate { get; set; }

		public RegisterLinkedCluekRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
