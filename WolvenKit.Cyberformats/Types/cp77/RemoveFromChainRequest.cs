using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RemoveFromChainRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("requestSource")] public entEntityID RequestSource { get; set; }

		public RemoveFromChainRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
