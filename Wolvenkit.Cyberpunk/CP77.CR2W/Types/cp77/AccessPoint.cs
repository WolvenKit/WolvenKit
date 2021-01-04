using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AccessPoint : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("breachViewTimeListener")] public CHandle<BreachViewTimeListener> BreachViewTimeListener { get; set; }
		[Ordinal(1)]  [RED("diode0")] public CHandle<gameLightComponent> Diode0 { get; set; }
		[Ordinal(2)]  [RED("diode1")] public CHandle<gameLightComponent> Diode1 { get; set; }
		[Ordinal(3)]  [RED("diode2")] public CHandle<gameLightComponent> Diode2 { get; set; }
		[Ordinal(4)]  [RED("diode3")] public CHandle<gameLightComponent> Diode3 { get; set; }
		[Ordinal(5)]  [RED("elapsedTime")] public CFloat ElapsedTime { get; set; }
		[Ordinal(6)]  [RED("isPlayerInBreachView")] public CBool IsPlayerInBreachView { get; set; }
		[Ordinal(7)]  [RED("isRevealed")] public CBool IsRevealed { get; set; }
		[Ordinal(8)]  [RED("networkName")] public CString NetworkName { get; set; }
		[Ordinal(9)]  [RED("turnOnLight")] public CBool TurnOnLight { get; set; }
		[Ordinal(10)]  [RED("upload_program_listener_id")] public CUInt32 Upload_program_listener_id { get; set; }

		public AccessPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
