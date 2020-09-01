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
		[Ordinal(1)] [RED("("leftRemoveAtEnd")] 		public CBool LeftRemoveAtEnd { get; set;}

		[Ordinal(2)] [RED("("leftDropOnBreak")] 		public CBool LeftDropOnBreak { get; set;}

		[Ordinal(3)] [RED("("rightRemoveAtEnd")] 		public CBool RightRemoveAtEnd { get; set;}

		[Ordinal(4)] [RED("("rightDropOnBreak")] 		public CBool RightDropOnBreak { get; set;}

		[Ordinal(5)] [RED("("ignoreHardReactions")] 		public CBool IgnoreHardReactions { get; set;}

		[Ordinal(6)] [RED("("needsPrecision")] 		public CBool NeedsPrecision { get; set;}

		[Ordinal(7)] [RED("("isConscious")] 		public CBool IsConscious { get; set;}

		[Ordinal(8)] [RED("("altJobTreeRes")] 		public CHandle<CJobTree> AltJobTreeRes { get; set;}

		[Ordinal(9)] [RED("("globalBreakingBlendOutTime")] 		public CFloat GlobalBreakingBlendOutTime { get; set;}

		[Ordinal(10)] [RED("("forceKeepIKactive")] 		public CBool ForceKeepIKactive { get; set;}

		[Ordinal(11)] [RED("("jobTreeType")] 		public CInt32 JobTreeType { get; set;}

		public SJobTreeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SJobTreeSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}