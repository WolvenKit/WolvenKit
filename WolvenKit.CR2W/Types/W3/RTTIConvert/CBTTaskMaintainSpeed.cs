using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMaintainSpeed : IBehTreeTask
	{
		[Ordinal(1)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(2)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(3)] [RED("manageFlySpeed")] 		public CBool ManageFlySpeed { get; set;}

		[Ordinal(4)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(5)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(6)] [RED("speedDecay")] 		public CBool SpeedDecay { get; set;}

		[Ordinal(7)] [RED("speedDecayOnDeactivate")] 		public CBool SpeedDecayOnDeactivate { get; set;}

		[Ordinal(8)] [RED("overrideForThisTask")] 		public CBool OverrideForThisTask { get; set;}

		[Ordinal(9)] [RED("decayAfter")] 		public CFloat DecayAfter { get; set;}

		[Ordinal(10)] [RED("previousSpeed")] 		public CFloat PreviousSpeed { get; set;}

		public CBTTaskMaintainSpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMaintainSpeed(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}