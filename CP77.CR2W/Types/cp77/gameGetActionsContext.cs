using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameGetActionsContext : CVariable
	{
		[Ordinal(0)]  [RED("actionPrereqs")] public CArray<gameActionPrereqs> ActionPrereqs { get; set; }
		[Ordinal(1)]  [RED("clearance")] public CHandle<gamedeviceClearance> Clearance { get; set; }
		[Ordinal(2)]  [RED("ignoresAuthorization")] public CBool IgnoresAuthorization { get; set; }
		[Ordinal(3)]  [RED("ignoresRPG")] public CBool IgnoresRPG { get; set; }
		[Ordinal(4)]  [RED("interactionLayerTag")] public CName InteractionLayerTag { get; set; }
		[Ordinal(5)]  [RED("processInitiatorObject")] public wCHandle<gameObject> ProcessInitiatorObject { get; set; }
		[Ordinal(6)]  [RED("requestType")] public CEnum<gamedeviceRequestType> RequestType { get; set; }
		[Ordinal(7)]  [RED("requestorID")] public entEntityID RequestorID { get; set; }

		public gameGetActionsContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
