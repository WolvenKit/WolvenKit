using System.IO;using System.Runtime.Serialization;
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

		public W3GenericSceneArea(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3GenericSceneArea(cr2w);

	}
}