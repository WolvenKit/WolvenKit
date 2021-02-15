using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CooldownPackage : IScriptable
	{
		[Ordinal(0)] [RED("actionID")] public TweakDBID ActionID { get; set; }
		[Ordinal(1)] [RED("addressees")] public CArray<PSOwnerData> Addressees { get; set; }
		[Ordinal(2)] [RED("initialCooldown")] public CFloat InitialCooldown { get; set; }
		[Ordinal(3)] [RED("label")] public CooldownStorageID Label { get; set; }
		[Ordinal(4)] [RED("packageStatus")] public CEnum<PackageStatus> PackageStatus { get; set; }

		public CooldownPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
