using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSwarmSpawnAnimDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("useSwarms")] 		public CBool UseSwarms { get; set;}

		[Ordinal(2)] [RED("manageGravity")] 		public CBool ManageGravity { get; set;}

		[Ordinal(3)] [RED("spawnCondition")] 		public CEnum<ESpawnCondition> SpawnCondition { get; set;}

		[Ordinal(4)] [RED("swarmStabilizeTime")] 		public CFloat SwarmStabilizeTime { get; set;}

		[Ordinal(5)] [RED("distToActors")] 		public CFloat DistToActors { get; set;}

		[Ordinal(6)] [RED("delayMain")] 		public CFloat DelayMain { get; set;}

		[Ordinal(7)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(8)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(9)] [RED("initialAppearance")] 		public CName InitialAppearance { get; set;}

		[Ordinal(10)] [RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[Ordinal(11)] [RED("playFXOnAnimEvent")] 		public CBool PlayFXOnAnimEvent { get; set;}

		[Ordinal(12)] [RED("animEventNameActivator")] 		public CName AnimEventNameActivator { get; set;}

		public CBTTaskSwarmSpawnAnimDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSwarmSpawnAnimDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}