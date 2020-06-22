using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlaySyncedAnimation : IBehTreeTask
	{
		[RED("isRunning")] 		public CBool IsRunning { get; set;}

		[RED("shouldStartAnimation")] 		public CBool ShouldStartAnimation { get; set;}

		[RED("syncInstance")] 		public CHandle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

		[RED("sequenceIndex")] 		public CInt32 SequenceIndex { get; set;}

		[RED("forceEventOnEnd")] 		public CName ForceEventOnEnd { get; set;}

		[RED("gameplayEventOnEnd")] 		public CName GameplayEventOnEnd { get; set;}

		[RED("finisherSyncAnim")] 		public CBool FinisherSyncAnim { get; set;}

		[RED("completeSuccess")] 		public CBool CompleteSuccess { get; set;}

		public CBTTaskPlaySyncedAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlaySyncedAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}