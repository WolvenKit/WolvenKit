using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestManyActorsCondition : IQuestCondition
	{
		[RED("actorTags")] 		public TagList ActorTags { get; set;}

		[RED("logicOperation")] 		public CEnum<EQuestActorConditionLogicOperation> LogicOperation { get; set;}

		[RED("condition")] 		public CPtr<IActorConditionType> Condition { get; set;}

		public CQuestManyActorsCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestManyActorsCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}