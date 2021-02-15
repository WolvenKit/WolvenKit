using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UnregisterNetworkLinksByIdAndTypeRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("ID")] public entEntityID ID { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<ELinkType> Type { get; set; }

		public UnregisterNetworkLinksByIdAndTypeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
