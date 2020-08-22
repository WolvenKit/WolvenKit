using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSwarmSpawnAnim : IBehTreeTask
	{
		[RED("spawned")] 		public CBool Spawned { get; set;}

		[RED("spawnCondition")] 		public CEnum<ESpawnCondition> SpawnCondition { get; set;}

		[RED("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[RED("swarmStabilizeTime")] 		public CFloat SwarmStabilizeTime { get; set;}

		[RED("delayMain")] 		public CFloat DelayMain { get; set;}

		[RED("time")] 		public CFloat Time { get; set;}

		[RED("distToActors")] 		public CFloat DistToActors { get; set;}

		[RED("currTime")] 		public CFloat CurrTime { get; set;}

		[RED("initialTime")] 		public CFloat InitialTime { get; set;}

		[RED("useSwarms")] 		public CBool UseSwarms { get; set;}

		[RED("manageGravity")] 		public CBool ManageGravity { get; set;}

		[RED("animEventOccured")] 		public CBool AnimEventOccured { get; set;}

		[RED("despawnCalled")] 		public CBool DespawnCalled { get; set;}

		[RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[RED("fxName")] 		public CName FxName { get; set;}

		[RED("initialAppearance")] 		public CName InitialAppearance { get; set;}

		[RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[RED("playFXOnAnimEvent")] 		public CBool PlayFXOnAnimEvent { get; set;}

		[RED("res")] 		public CBool Res { get; set;}

		[RED("fail")] 		public CBool Fail { get; set;}

		[RED("despawn")] 		public CBool Despawn { get; set;}

		[RED("animEventNameActivator")] 		public CName AnimEventNameActivator { get; set;}

		[RED("spawnCount")] 		public CInt32 SpawnCount { get; set;}

		public CBTTaskSwarmSpawnAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSwarmSpawnAnim(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}