using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GenericSceneArea : CGameplayEntity
	{
		[Ordinal(1)] [RED("scenes", 2,0)] 		public CArray<genericSceneDefinition> Scenes { get; set;}

		[Ordinal(2)] [RED("forbiddenFact")] 		public CString ForbiddenFact { get; set;}

		[Ordinal(3)] [RED("requiredFact")] 		public CString RequiredFact { get; set;}

		[Ordinal(4)] [RED("npcSearchRange")] 		public CFloat NpcSearchRange { get; set;}

		[Ordinal(5)] [RED("ignoreReplacers")] 		public CBool IgnoreReplacers { get; set;}

		[Ordinal(6)] [RED("includeEnemyNPCs")] 		public CBool IncludeEnemyNPCs { get; set;}

		[Ordinal(7)] [RED("includeQuestNPCs")] 		public CBool IncludeQuestNPCs { get; set;}

		[Ordinal(8)] [RED("sceneDelay")] 		public CFloat SceneDelay { get; set;}

		[Ordinal(9)] [RED("firstPlaySceneDelay")] 		public CFloat FirstPlaySceneDelay { get; set;}

		[Ordinal(10)] [RED("currentSceneDelay")] 		public CFloat CurrentSceneDelay { get; set;}

		public W3GenericSceneArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3GenericSceneArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}