using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskDeathAnimDecorator : IBehTreeTask
	{
		[Ordinal(1)] [RED("disableThisBranch")] 		public CBool DisableThisBranch { get; set;}

		[Ordinal(2)] [RED("enabledRagdoll")] 		public CBool EnabledRagdoll { get; set;}

		[Ordinal(3)] [RED("disableCollisionOnAnim")] 		public CBool DisableCollisionOnAnim { get; set;}

		[Ordinal(4)] [RED("ignoreForceFinisher")] 		public CBool IgnoreForceFinisher { get; set;}

		[Ordinal(5)] [RED("disableCollisionOnAnimDelay")] 		public CFloat DisableCollisionOnAnimDelay { get; set;}

		[Ordinal(6)] [RED("completeTimer")] 		public CFloat CompleteTimer { get; set;}

		[Ordinal(7)] [RED("playFXOnActivate")] 		public CName PlayFXOnActivate { get; set;}

		[Ordinal(8)] [RED("playFXOnDeactivate")] 		public CName PlayFXOnDeactivate { get; set;}

		[Ordinal(9)] [RED("stopFXOnActivate")] 		public CName StopFXOnActivate { get; set;}

		[Ordinal(10)] [RED("stopFXOnDeactivate")] 		public CName StopFXOnDeactivate { get; set;}

		[Ordinal(11)] [RED("playSFXOnActivate")] 		public CName PlaySFXOnActivate { get; set;}

		[Ordinal(12)] [RED("syncInstance")] 		public CHandle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

		[Ordinal(13)] [RED("finisherEnabled")] 		public CBool FinisherEnabled { get; set;}

		public CBehTreeTaskDeathAnimDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskDeathAnimDecorator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}