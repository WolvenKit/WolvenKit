using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gsmGameDefinition : CResource
	{
		[Ordinal(1)] [RED("mainQuest")] public raRef<questQuestResource> MainQuest { get; set; }
		[Ordinal(2)] [RED("world")] public raRef<worldWorld> World { get; set; }
		[Ordinal(3)] [RED("streamingWorld")] public raRef<CResource> StreamingWorld { get; set; }
		[Ordinal(4)] [RED("worldName")] public CString WorldName { get; set; }
		[Ordinal(5)] [RED("spawnPointTags")] public redTagList SpawnPointTags { get; set; }

		public gsmGameDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
