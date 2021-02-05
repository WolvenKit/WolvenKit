using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class drillMachine : gameweaponObject
	{
		[Ordinal(46)]  [RED("rewireComponent")] public CHandle<RewireComponent> RewireComponent { get; set; }
		[Ordinal(47)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(48)]  [RED("scanManager")] public CHandle<DrillMachineScanManager> ScanManager { get; set; }
		[Ordinal(49)]  [RED("screen_postprocess")] public CHandle<entIVisualComponent> Screen_postprocess { get; set; }
		[Ordinal(50)]  [RED("screen_backside")] public CHandle<entIVisualComponent> Screen_backside { get; set; }
		[Ordinal(51)]  [RED("isScanning")] public CBool IsScanning { get; set; }
		[Ordinal(52)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(53)]  [RED("targetDevice")] public wCHandle<gameObject> TargetDevice { get; set; }

		public drillMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
