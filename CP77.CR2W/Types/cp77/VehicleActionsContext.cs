using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleActionsContext : CVariable
	{
		[Ordinal(0)]  [RED("eventType")] public CEnum<gameinteractionsEInteractionEventType> EventType { get; set; }
		[Ordinal(1)]  [RED("interactionLayerTag")] public CName InteractionLayerTag { get; set; }
		[Ordinal(2)]  [RED("processInitiatorObject")] public wCHandle<gameObject> ProcessInitiatorObject { get; set; }
		[Ordinal(3)]  [RED("requestType")] public CEnum<gamedeviceRequestType> RequestType { get; set; }
		[Ordinal(4)]  [RED("requestorID")] public entEntityID RequestorID { get; set; }

		public VehicleActionsContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
