using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSStoryPhaseEntry : CVariable
	{
		[Ordinal(0)] [RED("("guid")] 		public CGUID Guid { get; set;}

		[Ordinal(0)] [RED("("comment")] 		public CString Comment { get; set;}

		[Ordinal(0)] [RED("("storyPhaseName")] 		public CSStoryPhaseNames StoryPhaseName { get; set;}

		[Ordinal(0)] [RED("("isHiddenSpawn")] 		public CBool IsHiddenSpawn { get; set;}

		[Ordinal(0)] [RED("("initializers")] 		public CPtr<CCommunityInitializers> Initializers { get; set;}

		[Ordinal(0)] [RED("("spawnTimetable", 2,0)] 		public CArray<CSStoryPhaseSpawnTimetableEntry> SpawnTimetable { get; set;}

		[Ordinal(0)] [RED("("timetableName")] 		public CName TimetableName { get; set;}

		[Ordinal(0)] [RED("("spawnDelay")] 		public GameTime SpawnDelay { get; set;}

		[Ordinal(0)] [RED("("spawnPointTags")] 		public TagList SpawnPointTags { get; set;}

		[Ordinal(0)] [RED("("despawnPointTags")] 		public TagList DespawnPointTags { get; set;}

		[Ordinal(0)] [RED("("startInAP")] 		public CBool StartInAP { get; set;}

		[Ordinal(0)] [RED("("useLastAP")] 		public CBool UseLastAP { get; set;}

		[Ordinal(0)] [RED("("alwaysSpawned")] 		public CBool AlwaysSpawned { get; set;}

		[Ordinal(0)] [RED("("spawnStrategy")] 		public CPtr<CCommunitySpawnStrategy> SpawnStrategy { get; set;}

		[Ordinal(0)] [RED("("cachedMapPinPosition")] 		public Vector CachedMapPinPosition { get; set;}

		public CSStoryPhaseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSStoryPhaseEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}