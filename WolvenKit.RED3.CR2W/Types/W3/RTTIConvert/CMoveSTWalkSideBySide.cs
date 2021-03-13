using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTWalkSideBySide : IMoveSteeringTask
	{
		[Ordinal(1)] [RED("sideBySideDistance")] 		public CFloat SideBySideDistance { get; set;}

		[Ordinal(2)] [RED("minApproachDistance")] 		public CFloat MinApproachDistance { get; set;}

		[Ordinal(3)] [RED("maxApproachDistance")] 		public CFloat MaxApproachDistance { get; set;}

		[Ordinal(4)] [RED("catchupSpeedMultiplier")] 		public CFloat CatchupSpeedMultiplier { get; set;}

		[Ordinal(5)] [RED("slowDownSpeedMultiplier")] 		public CFloat SlowDownSpeedMultiplier { get; set;}

		[Ordinal(6)] [RED("headingImportance")] 		public CFloat HeadingImportance { get; set;}

		[Ordinal(7)] [RED("speedImportance")] 		public CFloat SpeedImportance { get; set;}

		public CMoveSTWalkSideBySide(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTWalkSideBySide(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}