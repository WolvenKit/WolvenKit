using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SExternalEncounterTaskParams : CVariable
	{
		[RED("triggerWhenOutsideOwnerEncounterArea")] 		public CBool TriggerWhenOutsideOwnerEncounterArea { get; set;}

		[RED("shouldEncounterChangeState")] 		public CBool ShouldEncounterChangeState { get; set;}

		[RED("enableEncounter")] 		public CBool EnableEncounter { get; set;}

		[RED("encounterTag")] 		public CName EncounterTag { get; set;}

		[RED("delay")] 		public GameTimeWrapper Delay { get; set;}

		[RED("factOnTaskPerformed")] 		public CString FactOnTaskPerformed { get; set;}

		[RED("spawnTreeNodesToActivate", 2,0)] 		public CArray<CName> SpawnTreeNodesToActivate { get; set;}

		[RED("spawnTreeNodesToDeactivate", 2,0)] 		public CArray<CName> SpawnTreeNodesToDeactivate { get; set;}

		[RED("creaturesGroupToDisable", 2,0)] 		public CArray<CName> CreaturesGroupToDisable { get; set;}

		[RED("creaturesGroupToEnable", 2,0)] 		public CArray<CName> CreaturesGroupToEnable { get; set;}

		[RED("sourceName")] 		public CName SourceName { get; set;}

		[RED("forceDespawn")] 		public CBool ForceDespawn { get; set;}

		[RED("encounterPhasetoActivate")] 		public CName EncounterPhasetoActivate { get; set;}

		[RED("ID")] 		public CInt32 ID { get; set;}

		[RED("setTime")] 		public GameTime SetTime { get; set;}

		public SExternalEncounterTaskParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SExternalEncounterTaskParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}