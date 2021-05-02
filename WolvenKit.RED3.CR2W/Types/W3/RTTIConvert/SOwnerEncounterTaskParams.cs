using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SOwnerEncounterTaskParams : CVariable
	{
		[Ordinal(1)] [RED("triggerWhenOutsideOwnerEncounterArea")] 		public CBool TriggerWhenOutsideOwnerEncounterArea { get; set;}

		[Ordinal(2)] [RED("deactivateEncounter")] 		public CBool DeactivateEncounter { get; set;}

		[Ordinal(3)] [RED("delay")] 		public GameTimeWrapper Delay { get; set;}

		[Ordinal(4)] [RED("factOnTaskPerformed")] 		public CString FactOnTaskPerformed { get; set;}

		[Ordinal(5)] [RED("spawnTreeNodesToActivate", 2,0)] 		public CArray<CName> SpawnTreeNodesToActivate { get; set;}

		[Ordinal(6)] [RED("spawnTreeNodesToDeactivate", 2,0)] 		public CArray<CName> SpawnTreeNodesToDeactivate { get; set;}

		[Ordinal(7)] [RED("encounterPhasetoActivate")] 		public CName EncounterPhasetoActivate { get; set;}

		[Ordinal(8)] [RED("creaturesGroupToDisable", 2,0)] 		public CArray<CName> CreaturesGroupToDisable { get; set;}

		[Ordinal(9)] [RED("creaturesGroupToEnable", 2,0)] 		public CArray<CName> CreaturesGroupToEnable { get; set;}

		[Ordinal(10)] [RED("sourceName")] 		public CName SourceName { get; set;}

		[Ordinal(11)] [RED("forceDespawn")] 		public CBool ForceDespawn { get; set;}

		[Ordinal(12)] [RED("ID")] 		public CInt32 ID { get; set;}

		[Ordinal(13)] [RED("setTime")] 		public GameTime SetTime { get; set;}

		public SOwnerEncounterTaskParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SOwnerEncounterTaskParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}