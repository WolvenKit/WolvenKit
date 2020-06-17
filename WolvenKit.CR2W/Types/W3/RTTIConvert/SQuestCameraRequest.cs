using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SQuestCameraRequest : CVariable
	{
		[RED("requestYaw")] 		public CBool RequestYaw { get; set;}

		[RED("yaw")] 		public CFloat Yaw { get; set;}

		[RED("requestPitch")] 		public CBool RequestPitch { get; set;}

		[RED("pitch")] 		public CFloat Pitch { get; set;}

		[RED("lookAtTag")] 		public CName LookAtTag { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("requestTimeStamp")] 		public CFloat RequestTimeStamp { get; set;}

		public SQuestCameraRequest(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SQuestCameraRequest(cr2w);

	}
}