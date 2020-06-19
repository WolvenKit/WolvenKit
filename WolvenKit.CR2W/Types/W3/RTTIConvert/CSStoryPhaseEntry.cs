using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSStoryPhaseEntry : CVariable
	{
		[RED("guid")] 		public CGUID Guid { get; set;}

		[RED("comment")] 		public CString Comment { get; set;}

		[RED("storyPhaseName")] 		public CSStoryPhaseNames StoryPhaseName { get; set;}

		[RED("isHiddenSpawn")] 		public CBool IsHiddenSpawn { get; set;}

		[RED("initializers")] 		public CPtr<CCommunityInitializers> Initializers { get; set;}

		[RED("spawnTimetable", 2,0)] 		public CArray<CSStoryPhaseSpawnTimetableEntry> SpawnTimetable { get; set;}

		[RED("timetableName")] 		public CName TimetableName { get; set;}

		[RED("spawnDelay")] 		public GameTime SpawnDelay { get; set;}

		[RED("spawnPointTags")] 		public TagList SpawnPointTags { get; set;}

		[RED("despawnPointTags")] 		public TagList DespawnPointTags { get; set;}

		[RED("startInAP")] 		public CBool StartInAP { get; set;}

		[RED("useLastAP")] 		public CBool UseLastAP { get; set;}

		[RED("alwaysSpawned")] 		public CBool AlwaysSpawned { get; set;}

		[RED("spawnStrategy")] 		public CPtr<CCommunitySpawnStrategy> SpawnStrategy { get; set;}

		[RED("cachedMapPinPosition")] 		public Vector CachedMapPinPosition { get; set;}

		public CSStoryPhaseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSStoryPhaseEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}