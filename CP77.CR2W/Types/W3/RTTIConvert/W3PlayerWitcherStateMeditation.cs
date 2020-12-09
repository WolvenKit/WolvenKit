using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerWitcherStateMeditation : W3PlayerWitcherStateMeditationBase
	{
		[Ordinal(1)] [RED("meditationPointHeading")] 		public CFloat MeditationPointHeading { get; set;}

		[Ordinal(2)] [RED("meditationHeadingSet")] 		public CBool MeditationHeadingSet { get; set;}

		[Ordinal(3)] [RED("stopRequested")] 		public CBool StopRequested { get; set;}

		[Ordinal(4)] [RED("isSitting")] 		public CBool IsSitting { get; set;}

		[Ordinal(5)] [RED("closeUIOnStop")] 		public CBool CloseUIOnStop { get; set;}

		[Ordinal(6)] [RED("cameraIsLeavingState")] 		public CBool CameraIsLeavingState { get; set;}

		[Ordinal(7)] [RED("isEntryFunctionLocked")] 		public CBool IsEntryFunctionLocked { get; set;}

		[Ordinal(8)] [RED("scheduledGoToWaiting")] 		public CBool ScheduledGoToWaiting { get; set;}

		[Ordinal(9)] [RED("changedContext")] 		public CBool ChangedContext { get; set;}

		public W3PlayerWitcherStateMeditation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerWitcherStateMeditation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}