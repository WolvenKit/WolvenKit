using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTWalkSideBySide : IMoveSteeringTask
	{
		[Ordinal(0)] [RED("sideBySideDistance")] 		public CFloat SideBySideDistance { get; set;}

		[Ordinal(0)] [RED("minApproachDistance")] 		public CFloat MinApproachDistance { get; set;}

		[Ordinal(0)] [RED("maxApproachDistance")] 		public CFloat MaxApproachDistance { get; set;}

		[Ordinal(0)] [RED("catchupSpeedMultiplier")] 		public CFloat CatchupSpeedMultiplier { get; set;}

		[Ordinal(0)] [RED("slowDownSpeedMultiplier")] 		public CFloat SlowDownSpeedMultiplier { get; set;}

		[Ordinal(0)] [RED("headingImportance")] 		public CFloat HeadingImportance { get; set;}

		[Ordinal(0)] [RED("speedImportance")] 		public CFloat SpeedImportance { get; set;}

		public CMoveSTWalkSideBySide(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTWalkSideBySide(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}