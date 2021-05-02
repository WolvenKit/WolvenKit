using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_EntityComponentEnabled : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(2)] [RED("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(3)] [RED("inverted")] 		public CBool Inverted { get; set;}

		[Ordinal(4)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(5)] [RED("component")] 		public CHandle<CComponent> Component { get; set;}

		[Ordinal(6)] [RED("listener")] 		public CHandle<W3QuestCond_EntityComponentEnabled_Listener> Listener { get; set;}

		public W3QuestCond_EntityComponentEnabled(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}