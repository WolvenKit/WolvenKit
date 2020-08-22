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
		[RED("reactionDebugType")] 		public CInt32 ReactionDebugType { get; set;}

		[RED("lookAtDurationGlance")] 		public CFloat LookAtDurationGlance { get; set;}

		[RED("lookAtDurationLook")] 		public CFloat LookAtDurationLook { get; set;}

		[RED("lookAtDurationGaze")] 		public CFloat LookAtDurationGaze { get; set;}

		[RED("lookAtDurationStare")] 		public CFloat LookAtDurationStare { get; set;}

		[RED("lookAtDurationRandGlance")] 		public CFloat LookAtDurationRandGlance { get; set;}

		[RED("lookAtDurationRandLook")] 		public CFloat LookAtDurationRandLook { get; set;}

		[RED("lookAtDurationRandGaze")] 		public CFloat LookAtDurationRandGaze { get; set;}

		[RED("lookAtDurationRandStare")] 		public CFloat LookAtDurationRandStare { get; set;}

		[RED("lookAtRangeGlance")] 		public CFloat LookAtRangeGlance { get; set;}

		[RED("lookAtRangeLook")] 		public CFloat LookAtRangeLook { get; set;}

		[RED("lookAtRangeGaze")] 		public CFloat LookAtRangeGaze { get; set;}

		[RED("lookAtRangeStare")] 		public CFloat LookAtRangeStare { get; set;}

		[RED("lookAtSpeedGlance")] 		public CFloat LookAtSpeedGlance { get; set;}

		[RED("lookAtSpeedLook")] 		public CFloat LookAtSpeedLook { get; set;}

		[RED("lookAtSpeedGaze")] 		public CFloat LookAtSpeedGaze { get; set;}

		[RED("lookAtSpeedStare")] 		public CFloat LookAtSpeedStare { get; set;}

		[RED("lookAtSpeedRandGlance")] 		public CFloat LookAtSpeedRandGlance { get; set;}

		[RED("lookAtSpeedRandLook")] 		public CFloat LookAtSpeedRandLook { get; set;}

		[RED("lookAtSpeedRandGaze")] 		public CFloat LookAtSpeedRandGaze { get; set;}

		[RED("lookAtSpeedRandStare")] 		public CFloat LookAtSpeedRandStare { get; set;}

		[RED("lookAtAutoLimitGlance")] 		public CBool LookAtAutoLimitGlance { get; set;}

		[RED("lookAtAutoLimitLook")] 		public CBool LookAtAutoLimitLook { get; set;}

		[RED("lookAtAutoLimitGaze")] 		public CBool LookAtAutoLimitGaze { get; set;}

		[RED("lookAtAutoLimitStare")] 		public CBool LookAtAutoLimitStare { get; set;}

		[RED("lookAtDelay")] 		public CFloat LookAtDelay { get; set;}

		[RED("lookAtDelayDialog")] 		public CFloat LookAtDelayDialog { get; set;}

		public SGameplayConfigLookAts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayConfigLookAts(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}