using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TakedownActionDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("eventType")] public CEnum<ETakedownActionType> EventType { get; set; }

		public TakedownActionDataTrackingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
