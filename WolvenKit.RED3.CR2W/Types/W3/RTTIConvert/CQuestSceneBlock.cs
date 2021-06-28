using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestSceneBlock : CQuestGraphBlock
	{
		[Ordinal(1)] [RED("scene")] 		public CSoft<CStoryScene> Scene { get; set;}

		[Ordinal(2)] [RED("forcingMode")] 		public CEnum<EStorySceneForcingMode> ForcingMode { get; set;}

		[Ordinal(3)] [RED("forceSpawnedActors")] 		public CBool ForceSpawnedActors { get; set;}

		[Ordinal(4)] [RED("interrupt")] 		public CBool Interrupt { get; set;}

		[Ordinal(5)] [RED("shouldFadeOnLoading")] 		public CBool ShouldFadeOnLoading { get; set;}

		[Ordinal(6)] [RED("shouldFadeOnLoading_NamesCooked", 2,0)] 		public CArray<CName> ShouldFadeOnLoading_NamesCooked { get; set;}

		[Ordinal(7)] [RED("shouldFadeOnLoading_ValuesCooked", 2,0)] 		public CArray<CBool> ShouldFadeOnLoading_ValuesCooked { get; set;}

		[Ordinal(8)] [RED("saveMode")] 		public CEnum<EQuestSceneSaveMode> SaveMode { get; set;}

		[Ordinal(9)] [RED("saveSkipOutputNode")] 		public CName SaveSkipOutputNode { get; set;}

		[Ordinal(10)] [RED("playGoChunk")] 		public CName PlayGoChunk { get; set;}

		public CQuestSceneBlock(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}