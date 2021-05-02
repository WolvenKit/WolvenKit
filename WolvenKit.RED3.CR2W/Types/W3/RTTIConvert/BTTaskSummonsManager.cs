using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSummonsManager : IBehTreeTask
	{
		[Ordinal(1)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(2)] [RED("summonedEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> SummonedEntities { get; set;}

		[Ordinal(3)] [RED("summonedEntitiesSearchingRange")] 		public CFloat SummonedEntitiesSearchingRange { get; set;}

		[Ordinal(4)] [RED("summonedEntitiesTag")] 		public CName SummonedEntitiesTag { get; set;}

		[Ordinal(5)] [RED("killEntitiesOnDistance")] 		public CBool KillEntitiesOnDistance { get; set;}

		[Ordinal(6)] [RED("killDistance")] 		public CFloat KillDistance { get; set;}

		public BTTaskSummonsManager(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskSummonsManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}