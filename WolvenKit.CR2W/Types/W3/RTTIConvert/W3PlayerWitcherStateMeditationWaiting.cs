using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerWitcherStateMeditationWaiting : W3PlayerWitcherStateMeditationBase
	{
		[Ordinal(1)] [RED("TARGET_HOURS_PER_MINUTE")] 		public CFloat TARGET_HOURS_PER_MINUTE { get; set;}

		[Ordinal(2)] [RED("BLEND_TIME_SECONDS_REAL")] 		public CFloat BLEND_TIME_SECONDS_REAL { get; set;}

		[Ordinal(3)] [RED("storedHoursPerMinute")] 		public CFloat StoredHoursPerMinute { get; set;}

		[Ordinal(4)] [RED("waitStartTime")] 		public GameTime WaitStartTime { get; set;}

		[Ordinal(5)] [RED("requestedTargetTime")] 		public GameTime RequestedTargetTime { get; set;}

		[Ordinal(6)] [RED("abortRequested")] 		public CBool AbortRequested { get; set;}

		public W3PlayerWitcherStateMeditationWaiting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerWitcherStateMeditationWaiting(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}