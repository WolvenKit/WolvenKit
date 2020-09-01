using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerWitcherStateMeditation : W3PlayerWitcherStateMeditationBase
	{
		[Ordinal(0)] [RED("("meditationPointHeading")] 		public CFloat MeditationPointHeading { get; set;}

		[Ordinal(0)] [RED("("meditationHeadingSet")] 		public CBool MeditationHeadingSet { get; set;}

		[Ordinal(0)] [RED("("stopRequested")] 		public CBool StopRequested { get; set;}

		[Ordinal(0)] [RED("("isSitting")] 		public CBool IsSitting { get; set;}

		[Ordinal(0)] [RED("("closeUIOnStop")] 		public CBool CloseUIOnStop { get; set;}

		[Ordinal(0)] [RED("("cameraIsLeavingState")] 		public CBool CameraIsLeavingState { get; set;}

		[Ordinal(0)] [RED("("isEntryFunctionLocked")] 		public CBool IsEntryFunctionLocked { get; set;}

		[Ordinal(0)] [RED("("scheduledGoToWaiting")] 		public CBool ScheduledGoToWaiting { get; set;}

		[Ordinal(0)] [RED("("changedContext")] 		public CBool ChangedContext { get; set;}

		public W3PlayerWitcherStateMeditation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerWitcherStateMeditation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}