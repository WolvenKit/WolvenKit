using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SExternalEncounterTaskParams : CVariable
	{
		[Ordinal(1)] [RED("triggerWhenOutsideOwnerEncounterArea")] 		public CBool TriggerWhenOutsideOwnerEncounterArea { get; set;}

		[Ordinal(2)] [RED("shouldEncounterChangeState")] 		public CBool ShouldEncounterChangeState { get; set;}

		[Ordinal(3)] [RED("enableEncounter")] 		public CBool EnableEncounter { get; set;}

		[Ordinal(4)] [RED("encounterTag")] 		public CName EncounterTag { get; set;}

		[Ordinal(5)] [RED("delay")] 		public GameTimeWrapper Delay { get; set;}

		[Ordinal(6)] [RED("factOnTaskPerformed")] 		public CString FactOnTaskPerformed { get; set;}

		[Ordinal(7)] [RED("spawnTreeNodesToActivate", 2,0)] 		public CArray<CName> SpawnTreeNodesToActivate { get; set;}

		[Ordinal(8)] [RED("spawnTreeNodesToDeactivate", 2,0)] 		public CArray<CName> SpawnTreeNodesToDeactivate { get; set;}

		[Ordinal(9)] [RED("creaturesGroupToDisable", 2,0)] 		public CArray<CName> CreaturesGroupToDisable { get; set;}

		[Ordinal(10)] [RED("creaturesGroupToEnable", 2,0)] 		public CArray<CName> CreaturesGroupToEnable { get; set;}

		[Ordinal(11)] [RED("sourceName")] 		public CName SourceName { get; set;}

		[Ordinal(12)] [RED("forceDespawn")] 		public CBool ForceDespawn { get; set;}

		[Ordinal(13)] [RED("encounterPhasetoActivate")] 		public CName EncounterPhasetoActivate { get; set;}

		[Ordinal(14)] [RED("ID")] 		public CInt32 ID { get; set;}

		[Ordinal(15)] [RED("setTime")] 		public GameTime SetTime { get; set;}

		public SExternalEncounterTaskParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SExternalEncounterTaskParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}