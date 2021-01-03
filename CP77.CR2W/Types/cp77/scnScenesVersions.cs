using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersions : CResource
	{
		[Ordinal(0)]  [RED("currentVersion")] public CUInt32 CurrentVersion { get; set; }
		[Ordinal(1)]  [RED("scenesChanges")] public CArray<scnScenesVersionsSceneChanges> ScenesChanges { get; set; }

		public scnScenesVersions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
