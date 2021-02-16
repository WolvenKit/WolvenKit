using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Agent : CVariable
	{
		[Ordinal(0)] [RED("link")] public DeviceLink Link { get; set; }
		[Ordinal(1)] [RED("reprimands")] public CArray<ReprimandData> Reprimands { get; set; }
		[Ordinal(2)] [RED("supportingAgents")] public CArray<gamePersistentID> SupportingAgents { get; set; }
		[Ordinal(3)] [RED("areas")] public CArray<DeviceLink> Areas { get; set; }
		[Ordinal(4)] [RED("incomingFilter")] public CEnum<EFilterType> IncomingFilter { get; set; }
		[Ordinal(5)] [RED("cachedDelayDuration")] public CFloat CachedDelayDuration { get; set; }

		public Agent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
