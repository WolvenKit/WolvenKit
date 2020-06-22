using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnAnim : IBehTreeTask
	{
		[RED("spawnCondition")] 		public CEnum<ESpawnCondition> SpawnCondition { get; set;}

		[RED("delayMain")] 		public CFloat DelayMain { get; set;}

		[RED("time")] 		public CFloat Time { get; set;}

		[RED("distToActors")] 		public CFloat DistToActors { get; set;}

		[RED("manageGravity")] 		public CBool ManageGravity { get; set;}

		[RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[RED("fxName")] 		public CName FxName { get; set;}

		[RED("initialAppearance")] 		public CName InitialAppearance { get; set;}

		[RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[RED("playFXOnAnimEvent")] 		public CBool PlayFXOnAnimEvent { get; set;}

		[RED("animEventNameActivator")] 		public CName AnimEventNameActivator { get; set;}

		[RED("monitorGroundContact")] 		public CBool MonitorGroundContact { get; set;}

		[RED("dealDamageOnAnimEvent")] 		public CName DealDamageOnAnimEvent { get; set;}

		[RED("becomeVisibleOnAnimEvent")] 		public CName BecomeVisibleOnAnimEvent { get; set;}

		[RED("tagToBeDamaged")] 		public CName TagToBeDamaged { get; set;}

		[RED("spawned")] 		public CBool Spawned { get; set;}

		[RED("canPlayHitAnim")] 		public CBool CanPlayHitAnim { get; set;}

		[RED("animEventOccured")] 		public CBool AnimEventOccured { get; set;}

		[RED("isVisible")] 		public CBool IsVisible { get; set;}

		public CBTTaskSpawnAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnAnim(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}