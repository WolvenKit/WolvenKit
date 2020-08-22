using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GenericSceneArea : CGameplayEntity
	{
		[RED("scenes", 2,0)] 		public CArray<genericSceneDefinition> Scenes { get; set;}

		[RED("forbiddenFact")] 		public CString ForbiddenFact { get; set;}

		[RED("requiredFact")] 		public CString RequiredFact { get; set;}

		[RED("npcSearchRange")] 		public CFloat NpcSearchRange { get; set;}

		[RED("ignoreReplacers")] 		public CBool IgnoreReplacers { get; set;}

		[RED("includeEnemyNPCs")] 		public CBool IncludeEnemyNPCs { get; set;}

		[RED("includeQuestNPCs")] 		public CBool IncludeQuestNPCs { get; set;}

		[RED("sceneDelay")] 		public CFloat SceneDelay { get; set;}

		[RED("firstPlaySceneDelay")] 		public CFloat FirstPlaySceneDelay { get; set;}

		[RED("currentSceneDelay")] 		public CFloat CurrentSceneDelay { get; set;}

		public W3GenericSceneArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3GenericSceneArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}