using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEncounterActivator : CGameplayEntity
	{
		[Ordinal(1)] [RED("encounterAreaTag")] 		public CName EncounterAreaTag { get; set;}

		[Ordinal(2)] [RED("phaseToActivate")] 		public CName PhaseToActivate { get; set;}

		[Ordinal(3)] [RED("disableEncounterOnExit")] 		public CBool DisableEncounterOnExit { get; set;}

		[Ordinal(4)] [RED("encounter")] 		public CHandle<CEncounter> Encounter { get; set;}

		[Ordinal(5)] [RED("isPlayerInArea")] 		public CBool IsPlayerInArea { get; set;}

		public CEncounterActivator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEncounterActivator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}