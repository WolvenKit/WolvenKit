using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class communitySpawnEntry : ISerializable
	{
		[Ordinal(0)]  [RED("characterRecordId")] public TweakDBID CharacterRecordId { get; set; }
		[Ordinal(1)]  [RED("entryName")] public CName EntryName { get; set; }
		[Ordinal(2)]  [RED("initializers")] public CArray<CHandle<communitySpawnInitializer>> Initializers { get; set; }
		[Ordinal(3)]  [RED("phases")] public CArray<CHandle<communitySpawnPhase>> Phases { get; set; }
		[Ordinal(4)]  [RED("spawnInView")] public CEnum<gameSpawnInViewState> SpawnInView { get; set; }

		public communitySpawnEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
