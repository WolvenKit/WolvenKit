using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayConfigLookAts : CVariable
	{
		[Ordinal(1)] [RED("("reactionDebugType")] 		public CInt32 ReactionDebugType { get; set;}

		[Ordinal(2)] [RED("("lookAtDurationGlance")] 		public CFloat LookAtDurationGlance { get; set;}

		[Ordinal(3)] [RED("("lookAtDurationLook")] 		public CFloat LookAtDurationLook { get; set;}

		[Ordinal(4)] [RED("("lookAtDurationGaze")] 		public CFloat LookAtDurationGaze { get; set;}

		[Ordinal(5)] [RED("("lookAtDurationStare")] 		public CFloat LookAtDurationStare { get; set;}

		[Ordinal(6)] [RED("("lookAtDurationRandGlance")] 		public CFloat LookAtDurationRandGlance { get; set;}

		[Ordinal(7)] [RED("("lookAtDurationRandLook")] 		public CFloat LookAtDurationRandLook { get; set;}

		[Ordinal(8)] [RED("("lookAtDurationRandGaze")] 		public CFloat LookAtDurationRandGaze { get; set;}

		[Ordinal(9)] [RED("("lookAtDurationRandStare")] 		public CFloat LookAtDurationRandStare { get; set;}

		[Ordinal(10)] [RED("("lookAtRangeGlance")] 		public CFloat LookAtRangeGlance { get; set;}

		[Ordinal(11)] [RED("("lookAtRangeLook")] 		public CFloat LookAtRangeLook { get; set;}

		[Ordinal(12)] [RED("("lookAtRangeGaze")] 		public CFloat LookAtRangeGaze { get; set;}

		[Ordinal(13)] [RED("("lookAtRangeStare")] 		public CFloat LookAtRangeStare { get; set;}

		[Ordinal(14)] [RED("("lookAtSpeedGlance")] 		public CFloat LookAtSpeedGlance { get; set;}

		[Ordinal(15)] [RED("("lookAtSpeedLook")] 		public CFloat LookAtSpeedLook { get; set;}

		[Ordinal(16)] [RED("("lookAtSpeedGaze")] 		public CFloat LookAtSpeedGaze { get; set;}

		[Ordinal(17)] [RED("("lookAtSpeedStare")] 		public CFloat LookAtSpeedStare { get; set;}

		[Ordinal(18)] [RED("("lookAtSpeedRandGlance")] 		public CFloat LookAtSpeedRandGlance { get; set;}

		[Ordinal(19)] [RED("("lookAtSpeedRandLook")] 		public CFloat LookAtSpeedRandLook { get; set;}

		[Ordinal(20)] [RED("("lookAtSpeedRandGaze")] 		public CFloat LookAtSpeedRandGaze { get; set;}

		[Ordinal(21)] [RED("("lookAtSpeedRandStare")] 		public CFloat LookAtSpeedRandStare { get; set;}

		[Ordinal(22)] [RED("("lookAtAutoLimitGlance")] 		public CBool LookAtAutoLimitGlance { get; set;}

		[Ordinal(23)] [RED("("lookAtAutoLimitLook")] 		public CBool LookAtAutoLimitLook { get; set;}

		[Ordinal(24)] [RED("("lookAtAutoLimitGaze")] 		public CBool LookAtAutoLimitGaze { get; set;}

		[Ordinal(25)] [RED("("lookAtAutoLimitStare")] 		public CBool LookAtAutoLimitStare { get; set;}

		[Ordinal(26)] [RED("("lookAtDelay")] 		public CFloat LookAtDelay { get; set;}

		[Ordinal(27)] [RED("("lookAtDelayDialog")] 		public CFloat LookAtDelayDialog { get; set;}

		public SGameplayConfigLookAts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayConfigLookAts(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}