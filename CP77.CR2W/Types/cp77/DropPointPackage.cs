using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropPointPackage : IScriptable
	{
		[Ordinal(0)] [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(1)] [RED("status")] public CEnum<DropPointPackageStatus> Status { get; set; }
		[Ordinal(2)] [RED("predefinedDrop")] public gamePersistentID PredefinedDrop { get; set; }
		[Ordinal(3)] [RED("statusHistory")] public CArray<CEnum<DropPointPackageStatus>> StatusHistory { get; set; }

		public DropPointPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
