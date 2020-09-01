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
		[Ordinal(0)] [RED("("reactionDebugType")] 		public CInt32 ReactionDebugType { get; set;}

		[Ordinal(0)] [RED("("lookAtDurationGlance")] 		public CFloat LookAtDurationGlance { get; set;}

		[Ordinal(0)] [RED("("lookAtDurationLook")] 		public CFloat LookAtDurationLook { get; set;}

		[Ordinal(0)] [RED("("lookAtDurationGaze")] 		public CFloat LookAtDurationGaze { get; set;}

		[Ordinal(0)] [RED("("lookAtDurationStare")] 		public CFloat LookAtDurationStare { get; set;}

		[Ordinal(0)] [RED("("lookAtDurationRandGlance")] 		public CFloat LookAtDurationRandGlance { get; set;}

		[Ordinal(0)] [RED("("lookAtDurationRandLook")] 		public CFloat LookAtDurationRandLook { get; set;}

		[Ordinal(0)] [RED("("lookAtDurationRandGaze")] 		public CFloat LookAtDurationRandGaze { get; set;}

		[Ordinal(0)] [RED("("lookAtDurationRandStare")] 		public CFloat LookAtDurationRandStare { get; set;}

		[Ordinal(0)] [RED("("lookAtRangeGlance")] 		public CFloat LookAtRangeGlance { get; set;}

		[Ordinal(0)] [RED("("lookAtRangeLook")] 		public CFloat LookAtRangeLook { get; set;}

		[Ordinal(0)] [RED("("lookAtRangeGaze")] 		public CFloat LookAtRangeGaze { get; set;}

		[Ordinal(0)] [RED("("lookAtRangeStare")] 		public CFloat LookAtRangeStare { get; set;}

		[Ordinal(0)] [RED("("lookAtSpeedGlance")] 		public CFloat LookAtSpeedGlance { get; set;}

		[Ordinal(0)] [RED("("lookAtSpeedLook")] 		public CFloat LookAtSpeedLook { get; set;}

		[Ordinal(0)] [RED("("lookAtSpeedGaze")] 		public CFloat LookAtSpeedGaze { get; set;}

		[Ordinal(0)] [RED("("lookAtSpeedStare")] 		public CFloat LookAtSpeedStare { get; set;}

		[Ordinal(0)] [RED("("lookAtSpeedRandGlance")] 		public CFloat LookAtSpeedRandGlance { get; set;}

		[Ordinal(0)] [RED("("lookAtSpeedRandLook")] 		public CFloat LookAtSpeedRandLook { get; set;}

		[Ordinal(0)] [RED("("lookAtSpeedRandGaze")] 		public CFloat LookAtSpeedRandGaze { get; set;}

		[Ordinal(0)] [RED("("lookAtSpeedRandStare")] 		public CFloat LookAtSpeedRandStare { get; set;}

		[Ordinal(0)] [RED("("lookAtAutoLimitGlance")] 		public CBool LookAtAutoLimitGlance { get; set;}

		[Ordinal(0)] [RED("("lookAtAutoLimitLook")] 		public CBool LookAtAutoLimitLook { get; set;}

		[Ordinal(0)] [RED("("lookAtAutoLimitGaze")] 		public CBool LookAtAutoLimitGaze { get; set;}

		[Ordinal(0)] [RED("("lookAtAutoLimitStare")] 		public CBool LookAtAutoLimitStare { get; set;}

		[Ordinal(0)] [RED("("lookAtDelay")] 		public CFloat LookAtDelay { get; set;}

		[Ordinal(0)] [RED("("lookAtDelayDialog")] 		public CFloat LookAtDelayDialog { get; set;}

		public SGameplayConfigLookAts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayConfigLookAts(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}