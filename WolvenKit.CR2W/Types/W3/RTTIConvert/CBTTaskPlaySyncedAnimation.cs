using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlaySyncedAnimation : IBehTreeTask
	{
		[Ordinal(1)] [RED("isRunning")] 		public CBool IsRunning { get; set;}

		[Ordinal(2)] [RED("shouldStartAnimation")] 		public CBool ShouldStartAnimation { get; set;}

		[Ordinal(3)] [RED("syncInstance")] 		public CHandle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

		[Ordinal(4)] [RED("sequenceIndex")] 		public CInt32 SequenceIndex { get; set;}

		[Ordinal(5)] [RED("forceEventOnEnd")] 		public CName ForceEventOnEnd { get; set;}

		[Ordinal(6)] [RED("gameplayEventOnEnd")] 		public CName GameplayEventOnEnd { get; set;}

		[Ordinal(7)] [RED("finisherSyncAnim")] 		public CBool FinisherSyncAnim { get; set;}

		[Ordinal(8)] [RED("completeSuccess")] 		public CBool CompleteSuccess { get; set;}

		public CBTTaskPlaySyncedAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlaySyncedAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}