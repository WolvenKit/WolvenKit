using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneCutsceneSection : CStorySceneSection
	{
		[Ordinal(0)] [RED("("cutscene")] 		public CHandle<CCutsceneTemplate> Cutscene { get; set;}

		[Ordinal(0)] [RED("("point")] 		public TagList Point { get; set;}

		[Ordinal(0)] [RED("("looped")] 		public CBool Looped { get; set;}

		[Ordinal(0)] [RED("("actorOverrides", 2,0)] 		public CArray<SCutsceneActorOverrideMapping> ActorOverrides { get; set;}

		[Ordinal(0)] [RED("("clearActorsHands")] 		public CBool ClearActorsHands { get; set;}

		public CStorySceneCutsceneSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneCutsceneSection(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}