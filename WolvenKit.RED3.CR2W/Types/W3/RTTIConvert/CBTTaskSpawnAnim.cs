using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnAnim : IBehTreeTask
	{
		[Ordinal(1)] [RED("spawnCondition")] 		public CEnum<ESpawnCondition> SpawnCondition { get; set;}

		[Ordinal(2)] [RED("delayMain")] 		public CFloat DelayMain { get; set;}

		[Ordinal(3)] [RED("time")] 		public CFloat Time { get; set;}

		[Ordinal(4)] [RED("distToActors")] 		public CFloat DistToActors { get; set;}

		[Ordinal(5)] [RED("manageGravity")] 		public CBool ManageGravity { get; set;}

		[Ordinal(6)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(7)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(8)] [RED("initialAppearance")] 		public CName InitialAppearance { get; set;}

		[Ordinal(9)] [RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[Ordinal(10)] [RED("playFXOnAnimEvent")] 		public CBool PlayFXOnAnimEvent { get; set;}

		[Ordinal(11)] [RED("animEventNameActivator")] 		public CName AnimEventNameActivator { get; set;}

		[Ordinal(12)] [RED("monitorGroundContact")] 		public CBool MonitorGroundContact { get; set;}

		[Ordinal(13)] [RED("dealDamageOnAnimEvent")] 		public CName DealDamageOnAnimEvent { get; set;}

		[Ordinal(14)] [RED("becomeVisibleOnAnimEvent")] 		public CName BecomeVisibleOnAnimEvent { get; set;}

		[Ordinal(15)] [RED("tagToBeDamaged")] 		public CName TagToBeDamaged { get; set;}

		[Ordinal(16)] [RED("spawned")] 		public CBool Spawned { get; set;}

		[Ordinal(17)] [RED("canPlayHitAnim")] 		public CBool CanPlayHitAnim { get; set;}

		[Ordinal(18)] [RED("animEventOccured")] 		public CBool AnimEventOccured { get; set;}

		[Ordinal(19)] [RED("isVisible")] 		public CBool IsVisible { get; set;}

		public CBTTaskSpawnAnim(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}