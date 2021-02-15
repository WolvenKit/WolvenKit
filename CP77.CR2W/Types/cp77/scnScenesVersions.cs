using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersions : CResource
	{
		[Ordinal(1)] [RED("currentVersion")] public CUInt32 CurrentVersion { get; set; }
		[Ordinal(2)] [RED("scenesChanges")] public CArray<scnScenesVersionsSceneChanges> ScenesChanges { get; set; }

		public scnScenesVersions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
