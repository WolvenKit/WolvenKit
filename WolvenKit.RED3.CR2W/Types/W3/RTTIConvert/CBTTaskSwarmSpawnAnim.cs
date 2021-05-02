using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSwarmSpawnAnim : IBehTreeTask
	{
		[Ordinal(1)] [RED("spawned")] 		public CBool Spawned { get; set;}

		[Ordinal(2)] [RED("spawnCondition")] 		public CEnum<ESpawnCondition> SpawnCondition { get; set;}

		[Ordinal(3)] [RED("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[Ordinal(4)] [RED("swarmStabilizeTime")] 		public CFloat SwarmStabilizeTime { get; set;}

		[Ordinal(5)] [RED("delayMain")] 		public CFloat DelayMain { get; set;}

		[Ordinal(6)] [RED("time")] 		public CFloat Time { get; set;}

		[Ordinal(7)] [RED("distToActors")] 		public CFloat DistToActors { get; set;}

		[Ordinal(8)] [RED("currTime")] 		public CFloat CurrTime { get; set;}

		[Ordinal(9)] [RED("initialTime")] 		public CFloat InitialTime { get; set;}

		[Ordinal(10)] [RED("useSwarms")] 		public CBool UseSwarms { get; set;}

		[Ordinal(11)] [RED("manageGravity")] 		public CBool ManageGravity { get; set;}

		[Ordinal(12)] [RED("animEventOccured")] 		public CBool AnimEventOccured { get; set;}

		[Ordinal(13)] [RED("despawnCalled")] 		public CBool DespawnCalled { get; set;}

		[Ordinal(14)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(15)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(16)] [RED("initialAppearance")] 		public CName InitialAppearance { get; set;}

		[Ordinal(17)] [RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[Ordinal(18)] [RED("playFXOnAnimEvent")] 		public CBool PlayFXOnAnimEvent { get; set;}

		[Ordinal(19)] [RED("res")] 		public CBool Res { get; set;}

		[Ordinal(20)] [RED("fail")] 		public CBool Fail { get; set;}

		[Ordinal(21)] [RED("despawn")] 		public CBool Despawn { get; set;}

		[Ordinal(22)] [RED("animEventNameActivator")] 		public CName AnimEventNameActivator { get; set;}

		[Ordinal(23)] [RED("spawnCount")] 		public CInt32 SpawnCount { get; set;}

		public CBTTaskSwarmSpawnAnim(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}