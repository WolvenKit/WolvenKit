using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnAnimDef : IBehTreeTaskDefinition
	{
		[RED("useSwarms")] 		public CBool UseSwarms { get; set;}

		[RED("manageGravity")] 		public CBool ManageGravity { get; set;}

		[RED("spawnCondition")] 		public CEnum<ESpawnCondition> SpawnCondition { get; set;}

		[RED("distToActors")] 		public CFloat DistToActors { get; set;}

		[RED("delayMain")] 		public CFloat DelayMain { get; set;}

		[RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[RED("dealDamageOnAnimEvent")] 		public CBehTreeValCName DealDamageOnAnimEvent { get; set;}

		[RED("fxName")] 		public CBehTreeValCName FxName { get; set;}

		[RED("initialAppearance")] 		public CName InitialAppearance { get; set;}

		[RED("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[RED("playFXOnAnimEvent")] 		public CBehTreeValBool PlayFXOnAnimEvent { get; set;}

		[RED("animEventNameActivator")] 		public CBehTreeValCName AnimEventNameActivator { get; set;}

		[RED("monitorGroundContact")] 		public CBehTreeValBool MonitorGroundContact { get; set;}

		[RED("becomeVisibleOnAnimEvent")] 		public CBehTreeValCName BecomeVisibleOnAnimEvent { get; set;}

		[RED("tagToBeDamaged")] 		public CName TagToBeDamaged { get; set;}

		public CBTTaskSpawnAnimDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSpawnAnimDef(cr2w);

	}
}