using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class drillMachine : gameweaponObject
	{
		[Ordinal(0)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(1)]  [RED("isScanning")] public CBool IsScanning { get; set; }
		[Ordinal(2)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(3)]  [RED("rewireComponent")] public CHandle<RewireComponent> RewireComponent { get; set; }
		[Ordinal(4)]  [RED("scanManager")] public CHandle<DrillMachineScanManager> ScanManager { get; set; }
		[Ordinal(5)]  [RED("screen_backside")] public CHandle<entIVisualComponent> Screen_backside { get; set; }
		[Ordinal(6)]  [RED("screen_postprocess")] public CHandle<entIVisualComponent> Screen_postprocess { get; set; }
		[Ordinal(7)]  [RED("targetDevice")] public wCHandle<gameObject> TargetDevice { get; set; }

		public drillMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
