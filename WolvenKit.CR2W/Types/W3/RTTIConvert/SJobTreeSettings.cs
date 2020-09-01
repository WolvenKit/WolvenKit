using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SJobTreeSettings : CVariable
	{
		[Ordinal(0)] [RED("("leftRemoveAtEnd")] 		public CBool LeftRemoveAtEnd { get; set;}

		[Ordinal(0)] [RED("("leftDropOnBreak")] 		public CBool LeftDropOnBreak { get; set;}

		[Ordinal(0)] [RED("("rightRemoveAtEnd")] 		public CBool RightRemoveAtEnd { get; set;}

		[Ordinal(0)] [RED("("rightDropOnBreak")] 		public CBool RightDropOnBreak { get; set;}

		[Ordinal(0)] [RED("("ignoreHardReactions")] 		public CBool IgnoreHardReactions { get; set;}

		[Ordinal(0)] [RED("("needsPrecision")] 		public CBool NeedsPrecision { get; set;}

		[Ordinal(0)] [RED("("isConscious")] 		public CBool IsConscious { get; set;}

		[Ordinal(0)] [RED("("altJobTreeRes")] 		public CHandle<CJobTree> AltJobTreeRes { get; set;}

		[Ordinal(0)] [RED("("globalBreakingBlendOutTime")] 		public CFloat GlobalBreakingBlendOutTime { get; set;}

		[Ordinal(0)] [RED("("forceKeepIKactive")] 		public CBool ForceKeepIKactive { get; set;}

		[Ordinal(0)] [RED("("jobTreeType")] 		public CInt32 JobTreeType { get; set;}

		public SJobTreeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SJobTreeSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}