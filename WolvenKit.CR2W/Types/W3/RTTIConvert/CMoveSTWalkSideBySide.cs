using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTWalkSideBySide : IMoveSteeringTask
	{
		[RED("sideBySideDistance")] 		public CFloat SideBySideDistance { get; set;}

		[RED("minApproachDistance")] 		public CFloat MinApproachDistance { get; set;}

		[RED("maxApproachDistance")] 		public CFloat MaxApproachDistance { get; set;}

		[RED("catchupSpeedMultiplier")] 		public CFloat CatchupSpeedMultiplier { get; set;}

		[RED("slowDownSpeedMultiplier")] 		public CFloat SlowDownSpeedMultiplier { get; set;}

		[RED("headingImportance")] 		public CFloat HeadingImportance { get; set;}

		[RED("speedImportance")] 		public CFloat SpeedImportance { get; set;}

		public CMoveSTWalkSideBySide(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTWalkSideBySide(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}