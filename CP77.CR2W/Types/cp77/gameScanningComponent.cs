using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponent : gameComponent
	{
		[Ordinal(0)]  [RED("cpoEnableMultiplePlayersScanningModifier")] public CBool CpoEnableMultiplePlayersScanningModifier { get; set; }
		[Ordinal(1)]  [RED("autoGenerateBoundingSphere")] public CBool AutoGenerateBoundingSphere { get; set; }
		[Ordinal(2)]  [RED("ignoresScanningDistanceLimit")] public CBool IgnoresScanningDistanceLimit { get; set; }
		[Ordinal(3)]  [RED("timeNeeded")] public CFloat TimeNeeded { get; set; }
		[Ordinal(4)]  [RED("boundingSphere")] public Sphere BoundingSphere { get; set; }
		[Ordinal(5)]  [RED("scannableData")] public CArray<gameScanningTooltipElementDef> ScannableData { get; set; }

		public gameScanningComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
