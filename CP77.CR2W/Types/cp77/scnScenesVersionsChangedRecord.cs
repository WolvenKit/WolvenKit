using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersionsChangedRecord : CVariable
	{
		[Ordinal(0)]  [RED("changeInVersion")] public CUInt32 ChangeInVersion { get; set; }
		[Ordinal(1)]  [RED("sceneBeforeChange")] public raRef<scnSceneResource> SceneBeforeChange { get; set; }

		public scnScenesVersionsChangedRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
