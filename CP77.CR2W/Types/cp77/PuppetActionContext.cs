using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PuppetActionContext : CVariable
	{
		[Ordinal(0)] [RED("requesterID")] public entEntityID RequesterID { get; set; }
		[Ordinal(1)] [RED("requestType")] public CEnum<gamedeviceRequestType> RequestType { get; set; }

		public PuppetActionContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
