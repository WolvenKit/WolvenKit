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
		[RED("disableThisBranch")] 		public CBool DisableThisBranch { get; set;}

		[RED("enabledRagdoll")] 		public CBool EnabledRagdoll { get; set;}

		[RED("disableCollisionOnAnim")] 		public CBool DisableCollisionOnAnim { get; set;}

		[RED("ignoreForceFinisher")] 		public CBool IgnoreForceFinisher { get; set;}

		[RED("disableCollisionOnAnimDelay")] 		public CFloat DisableCollisionOnAnimDelay { get; set;}

		[RED("completeTimer")] 		public CFloat CompleteTimer { get; set;}

		[RED("playFXOnActivate")] 		public CName PlayFXOnActivate { get; set;}

		[RED("playFXOnDeactivate")] 		public CName PlayFXOnDeactivate { get; set;}

		[RED("stopFXOnActivate")] 		public CName StopFXOnActivate { get; set;}

		[RED("stopFXOnDeactivate")] 		public CName StopFXOnDeactivate { get; set;}

		[RED("playSFXOnActivate")] 		public CName PlaySFXOnActivate { get; set;}

		[RED("syncInstance")] 		public CHandle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

		[RED("finisherEnabled")] 		public CBool FinisherEnabled { get; set;}

		public CBehTreeTaskDeathAnimDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskDeathAnimDecorator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}