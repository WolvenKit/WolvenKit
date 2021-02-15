using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workWorkspotAnimsetEntry : CVariable
	{
		[Ordinal(0)] [RED("rig")] public raRef<animRig> Rig { get; set; }
		[Ordinal(1)] [RED("animations")] public animAnimSetup Animations { get; set; }
		[Ordinal(2)] [RED("loadingHandles")] public CArray<rRef<animAnimSet>> LoadingHandles { get; set; }

		public workWorkspotAnimsetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
