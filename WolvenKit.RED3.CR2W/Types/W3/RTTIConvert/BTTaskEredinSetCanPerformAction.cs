using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskEredinSetCanPerformAction : IBehTreeTask
	{
		[Ordinal(1)] [RED("combatDataStorage")] 		public CHandle<CBossAICombatStorage> CombatDataStorage { get; set;}

		[Ordinal(2)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(3)] [RED("action")] 		public CEnum<EBossAction> Action { get; set;}

		[Ordinal(4)] [RED("value")] 		public CBool Value { get; set;}

		[Ordinal(5)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		public BTTaskEredinSetCanPerformAction(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskEredinSetCanPerformAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}