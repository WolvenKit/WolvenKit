using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StimRequest : IScriptable
	{
		[Ordinal(0)] [RED("stimuli")] public CHandle<senseStimuliEvent> Stimuli { get; set; }
		[Ordinal(1)] [RED("hasExpirationDate")] public CBool HasExpirationDate { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("requestID")] public StimRequestID RequestID { get; set; }

		public StimRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
