using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnAnimDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("useSwarms")] 		public CBool UseSwarms { get; set;}

		[Ordinal(0)] [RED("("manageGravity")] 		public CBool ManageGravity { get; set;}

		[Ordinal(0)] [RED("("spawnCondition")] 		public CEnum<ESpawnCondition> SpawnCondition { get; set;}

		[Ordinal(0)] [RED("("distToActors")] 		public CFloat DistToActors { get; set;}

		[Ordinal(0)] [RED("("delayMain")] 		public CFloat DelayMain { get; set;}

		[Ordinal(0)] [RED("("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(0)] [RED("("dealDamageOnAnimEvent")] 		public CBehTreeValCName DealDamageOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("fxName")] 		public CBehTreeValCName FxName { get; set;}

		[Ordinal(0)] [RED("("initialAppearance")] 		public CName InitialAppearance { get; set;}

		[Ordinal(0)] [RED("("setAppearanceTo")] 		public CName SetAppearanceTo { get; set;}

		[Ordinal(0)] [RED("("playFXOnAnimEvent")] 		public CBehTreeValBool PlayFXOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("animEventNameActivator")] 		public CBehTreeValCName AnimEventNameActivator { get; set;}

		[Ordinal(0)] [RED("("monitorGroundContact")] 		public CBehTreeValBool MonitorGroundContact { get; set;}

		[Ordinal(0)] [RED("("becomeVisibleOnAnimEvent")] 		public CBehTreeValCName BecomeVisibleOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("tagToBeDamaged")] 		public CName TagToBeDamaged { get; set;}

		public CBTTaskSpawnAnimDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnAnimDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}