using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AccessPoint : InteractiveMasterDevice
	{
		[Ordinal(84)]  [RED("diode0")] public CHandle<gameLightComponent> Diode0 { get; set; }
		[Ordinal(85)]  [RED("diode1")] public CHandle<gameLightComponent> Diode1 { get; set; }
		[Ordinal(86)]  [RED("diode2")] public CHandle<gameLightComponent> Diode2 { get; set; }
		[Ordinal(87)]  [RED("diode3")] public CHandle<gameLightComponent> Diode3 { get; set; }
		[Ordinal(88)]  [RED("elapsedTime")] public CFloat ElapsedTime { get; set; }
		[Ordinal(89)]  [RED("turnOnLight")] public CBool TurnOnLight { get; set; }
		[Ordinal(90)]  [RED("networkName")] public CString NetworkName { get; set; }
		[Ordinal(91)]  [RED("isPlayerInBreachView")] public CBool IsPlayerInBreachView { get; set; }
		[Ordinal(92)]  [RED("isRevealed")] public CBool IsRevealed { get; set; }
		[Ordinal(93)]  [RED("breachViewTimeListener")] public CHandle<BreachViewTimeListener> BreachViewTimeListener { get; set; }
		[Ordinal(94)]  [RED("upload_program_listener_id")] public CUInt32 Upload_program_listener_id { get; set; }

		public AccessPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
