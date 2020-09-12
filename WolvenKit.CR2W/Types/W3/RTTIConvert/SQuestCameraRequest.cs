using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SQuestCameraRequest : CVariable
	{
		[Ordinal(1)] [RED("requestYaw")] 		public CBool RequestYaw { get; set;}

		[Ordinal(2)] [RED("yaw")] 		public CFloat Yaw { get; set;}

		[Ordinal(3)] [RED("requestPitch")] 		public CBool RequestPitch { get; set;}

		[Ordinal(4)] [RED("pitch")] 		public CFloat Pitch { get; set;}

		[Ordinal(5)] [RED("lookAtTag")] 		public CName LookAtTag { get; set;}

		[Ordinal(6)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(7)] [RED("requestTimeStamp")] 		public CFloat RequestTimeStamp { get; set;}

		public SQuestCameraRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SQuestCameraRequest(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}