using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SJobTreeSettings : CVariable
	{
		[RED("leftRemoveAtEnd")] 		public CBool LeftRemoveAtEnd { get; set;}

		[RED("leftDropOnBreak")] 		public CBool LeftDropOnBreak { get; set;}

		[RED("rightRemoveAtEnd")] 		public CBool RightRemoveAtEnd { get; set;}

		[RED("rightDropOnBreak")] 		public CBool RightDropOnBreak { get; set;}

		[RED("ignoreHardReactions")] 		public CBool IgnoreHardReactions { get; set;}

		[RED("needsPrecision")] 		public CBool NeedsPrecision { get; set;}

		[RED("isConscious")] 		public CBool IsConscious { get; set;}

		[RED("altJobTreeRes")] 		public CHandle<CJobTree> AltJobTreeRes { get; set;}

		[RED("globalBreakingBlendOutTime")] 		public CFloat GlobalBreakingBlendOutTime { get; set;}

		[RED("forceKeepIKactive")] 		public CBool ForceKeepIKactive { get; set;}

		[RED("jobTreeType")] 		public CInt32 JobTreeType { get; set;}

		public SJobTreeSettings(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SJobTreeSettings(cr2w);

	}
}