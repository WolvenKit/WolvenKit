using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleActionsContext : CVariable
	{
		[Ordinal(0)] [RED("requestorID")] public entEntityID RequestorID { get; set; }
		[Ordinal(1)] [RED("requestType")] public CEnum<gamedeviceRequestType> RequestType { get; set; }
		[Ordinal(2)] [RED("interactionLayerTag")] public CName InteractionLayerTag { get; set; }
		[Ordinal(3)] [RED("processInitiatorObject")] public wCHandle<gameObject> ProcessInitiatorObject { get; set; }
		[Ordinal(4)] [RED("eventType")] public CEnum<gameinteractionsEInteractionEventType> EventType { get; set; }

		public VehicleActionsContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
