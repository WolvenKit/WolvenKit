using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerWitcherStateMeditationWaiting : W3PlayerWitcherStateMeditationBase
	{
		[RED("TARGET_HOURS_PER_MINUTE")] 		public CFloat TARGET_HOURS_PER_MINUTE { get; set;}

		[RED("BLEND_TIME_SECONDS_REAL")] 		public CFloat BLEND_TIME_SECONDS_REAL { get; set;}

		[RED("storedHoursPerMinute")] 		public CFloat StoredHoursPerMinute { get; set;}

		[RED("waitStartTime")] 		public GameTime WaitStartTime { get; set;}

		[RED("requestedTargetTime")] 		public GameTime RequestedTargetTime { get; set;}

		[RED("abortRequested")] 		public CBool AbortRequested { get; set;}

		public W3PlayerWitcherStateMeditationWaiting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerWitcherStateMeditationWaiting(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}