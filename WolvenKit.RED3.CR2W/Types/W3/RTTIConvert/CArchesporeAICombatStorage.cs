using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CArchesporeAICombatStorage : IScriptable
	{
		[Ordinal(1)] [RED("myBaseEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> MyBaseEntities { get; set;}

		[Ordinal(2)] [RED("noBulbAreas", 2,0)] 		public CArray<CHandle<CAreaComponent>> NoBulbAreas { get; set;}

		[Ordinal(3)] [RED("currentlyUsedBase")] 		public CHandle<CGameplayEntity> CurrentlyUsedBase { get; set;}

		[Ordinal(4)] [RED("wasInitialized")] 		public CBool WasInitialized { get; set;}

		[Ordinal(5)] [RED("manualBulbCleanup")] 		public CBool ManualBulbCleanup { get; set;}

		public CArchesporeAICombatStorage(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}