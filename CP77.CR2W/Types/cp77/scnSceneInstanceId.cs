using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSceneInstanceId : CVariable
	{
		[Ordinal(0)]  [RED("hash")] public CUInt64 Hash { get; set; }
		[Ordinal(1)]  [RED("internalId")] public CUInt8 InternalId { get; set; }
		[Ordinal(2)]  [RED("ownerId")] public scnSceneInstanceOwnerId OwnerId { get; set; }
		[Ordinal(3)]  [RED("sceneId")] public scnSceneId SceneId { get; set; }

		public scnSceneInstanceId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
