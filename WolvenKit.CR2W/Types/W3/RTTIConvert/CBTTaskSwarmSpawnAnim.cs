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
		[Ordinal(0)] [RED("("spawned")] 		public CBool Spawned { get; set;}

		[Ordinal(0)] [RED("("spawnCondition")] 		public CEnum<ESpawnCondition> SpawnCondition { get; set;}

		[Ordinal(0)] [RED("("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[Ordinal(0)] [RED("("swarmStabilizeTime")] 		public CFloat SwarmStabilizeTime { get; set;}

		[Ordinal(0)] [RED("("delayMain")] 		public CFloat DelayMain { get; set;}

		[Ordinal(0)] [RED("("time")] 		public CFloat Time { get; set;}

		[Ordinal(0)] [RED("("distToActors")] 		public CFloat DistToActors { get; set;}

		[Ordinal(0)] [RED("("currTime")] 		public CFloat CurrTime { get; set;}

		[Ordinal(0)] [RED("("initialTime")] 		public CFloat InitialTime { get; set;}

		[Ordinal(0)] [RED("("useSwarms")] 		public CBool UseSwarms { get; set;}

		[Ordinal(0)] [RED("("manageGravity")] 		public CBool ManageGravity { get; set;}

		[Ordinal(0)] [RED("("animEventOccured")] 		public CBool AnimEventOccured { get; set;}

		[Ordinal(0)] [RED("("despawnCalled")] 		public CBool DespawnCalled { get; set;}

		[Ordinal(0)] [RED("("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(0)] [RED("("fxName")] 		public CName FxName { get; set;}

		[Ordinal(0)] [RED("("initialAppearance")] 		public CName InitialAppearance { get; set;}

		[Ordinal(0)] [RED("("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[Ordinal(0)] [RED("("playFXOnAnimEvent")] 		public CBool PlayFXOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("res")] 		public CBool Res { get; set;}

		[Ordinal(0)] [RED("("fail")] 		public CBool Fail { get; set;}

		[Ordinal(0)] [RED("("despawn")] 		public CBool Despawn { get; set;}

		[Ordinal(0)] [RED("("animEventNameActivator")] 		public CName AnimEventNameActivator { get; set;}

		[Ordinal(0)] [RED("("spawnCount")] 		public CInt32 SpawnCount { get; set;}

		public CBTTaskSwarmSpawnAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSwarmSpawnAnim(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}