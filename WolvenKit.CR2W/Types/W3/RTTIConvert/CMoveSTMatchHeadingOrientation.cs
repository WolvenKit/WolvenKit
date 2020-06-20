using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTMatchHeadingOrientation : IMoveSteeringTask
	{
		[RED("limitSpeedOnTurns")] 		public CBool LimitSpeedOnTurns { get; set;}

		[RED("maxAngleNotLimitingSpeed")] 		public CFloat MaxAngleNotLimitingSpeed { get; set;}

		[RED("speedLimitOnRotation")] 		public CFloat SpeedLimitOnRotation { get; set;}

		public CMoveSTMatchHeadingOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTMatchHeadingOrientation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}