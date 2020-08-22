using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSummonsManager : IBehTreeTask
	{
		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("summonedEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> SummonedEntities { get; set;}

		[RED("summonedEntitiesSearchingRange")] 		public CFloat SummonedEntitiesSearchingRange { get; set;}

		[RED("summonedEntitiesTag")] 		public CName SummonedEntitiesTag { get; set;}

		[RED("killEntitiesOnDistance")] 		public CBool KillEntitiesOnDistance { get; set;}

		[RED("killDistance")] 		public CFloat KillDistance { get; set;}

		public BTTaskSummonsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskSummonsManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}