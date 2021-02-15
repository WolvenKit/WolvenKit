using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamegpsSettings : CVariable
	{
		[Ordinal(0)] [RED("lineEffectOnFoot")] public raRef<worldEffect> LineEffectOnFoot { get; set; }
		[Ordinal(1)] [RED("lineEffectVehicle")] public raRef<worldEffect> LineEffectVehicle { get; set; }
		[Ordinal(2)] [RED("fixedPathOffset")] public Vector3 FixedPathOffset { get; set; }
		[Ordinal(3)] [RED("fixedPortalMappinOffset")] public Vector3 FixedPortalMappinOffset { get; set; }
		[Ordinal(4)] [RED("pathRefreshTimeInterval")] public CFloat PathRefreshTimeInterval { get; set; }
		[Ordinal(5)] [RED("lastPlayerNavmeshPositionRefreshTimeIntervalSecs")] public CFloat LastPlayerNavmeshPositionRefreshTimeIntervalSecs { get; set; }
		[Ordinal(6)] [RED("maxPathDisplayLength")] public CFloat MaxPathDisplayLength { get; set; }

		public gamegpsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
