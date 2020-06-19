using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestSceneBlock : CQuestGraphBlock
	{
		[RED("scene")] 		public CSoft<CStoryScene> Scene { get; set;}

		[RED("forcingMode")] 		public CEnum<EStorySceneForcingMode> ForcingMode { get; set;}

		[RED("forceSpawnedActors")] 		public CBool ForceSpawnedActors { get; set;}

		[RED("interrupt")] 		public CBool Interrupt { get; set;}

		[RED("shouldFadeOnLoading")] 		public CBool ShouldFadeOnLoading { get; set;}

		[RED("shouldFadeOnLoading_NamesCooked", 2,0)] 		public CArray<CName> ShouldFadeOnLoading_NamesCooked { get; set;}

		[RED("shouldFadeOnLoading_ValuesCooked", 2,0)] 		public CArray<CBool> ShouldFadeOnLoading_ValuesCooked { get; set;}

		[RED("saveMode")] 		public CEnum<EQuestSceneSaveMode> SaveMode { get; set;}

		[RED("saveSkipOutputNode")] 		public CName SaveSkipOutputNode { get; set;}

		[RED("playGoChunk")] 		public CName PlayGoChunk { get; set;}

		public CQuestSceneBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestSceneBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}