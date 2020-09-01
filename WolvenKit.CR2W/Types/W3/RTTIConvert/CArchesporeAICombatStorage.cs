using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CArchesporeAICombatStorage : IScriptable
	{
		[Ordinal(0)] [RED("myBaseEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> MyBaseEntities { get; set;}

		[Ordinal(0)] [RED("noBulbAreas", 2,0)] 		public CArray<CHandle<CAreaComponent>> NoBulbAreas { get; set;}

		[Ordinal(0)] [RED("currentlyUsedBase")] 		public CHandle<CGameplayEntity> CurrentlyUsedBase { get; set;}

		[Ordinal(0)] [RED("wasInitialized")] 		public CBool WasInitialized { get; set;}

		[Ordinal(0)] [RED("manualBulbCleanup")] 		public CBool ManualBulbCleanup { get; set;}

		public CArchesporeAICombatStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CArchesporeAICombatStorage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}