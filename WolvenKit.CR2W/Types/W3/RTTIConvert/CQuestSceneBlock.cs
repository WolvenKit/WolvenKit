using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestSceneBlock : CQuestGraphBlock
	{
		[Ordinal(0)] [RED("scene")] 		public CSoft<CStoryScene> Scene { get; set;}

		[Ordinal(0)] [RED("forcingMode")] 		public CEnum<EStorySceneForcingMode> ForcingMode { get; set;}

		[Ordinal(0)] [RED("forceSpawnedActors")] 		public CBool ForceSpawnedActors { get; set;}

		[Ordinal(0)] [RED("interrupt")] 		public CBool Interrupt { get; set;}

		[Ordinal(0)] [RED("shouldFadeOnLoading")] 		public CBool ShouldFadeOnLoading { get; set;}

		[Ordinal(0)] [RED("shouldFadeOnLoading_NamesCooked", 2,0)] 		public CArray<CName> ShouldFadeOnLoading_NamesCooked { get; set;}

		[Ordinal(0)] [RED("shouldFadeOnLoading_ValuesCooked", 2,0)] 		public CArray<CBool> ShouldFadeOnLoading_ValuesCooked { get; set;}

		[Ordinal(0)] [RED("saveMode")] 		public CEnum<EQuestSceneSaveMode> SaveMode { get; set;}

		[Ordinal(0)] [RED("saveSkipOutputNode")] 		public CName SaveSkipOutputNode { get; set;}

		[Ordinal(0)] [RED("playGoChunk")] 		public CName PlayGoChunk { get; set;}

		public CQuestSceneBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestSceneBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}