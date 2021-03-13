using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class drillMachine : gameweaponObject
	{
		[Ordinal(57)] [RED("rewireComponent")] public CHandle<RewireComponent> RewireComponent { get; set; }
		[Ordinal(58)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(59)] [RED("scanManager")] public CHandle<DrillMachineScanManager> ScanManager { get; set; }
		[Ordinal(60)] [RED("screen_postprocess")] public CHandle<entIVisualComponent> Screen_postprocess { get; set; }
		[Ordinal(61)] [RED("screen_backside")] public CHandle<entIVisualComponent> Screen_backside { get; set; }
		[Ordinal(62)] [RED("isScanning")] public CBool IsScanning { get; set; }
		[Ordinal(63)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(64)] [RED("targetDevice")] public wCHandle<gameObject> TargetDevice { get; set; }

		public drillMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
