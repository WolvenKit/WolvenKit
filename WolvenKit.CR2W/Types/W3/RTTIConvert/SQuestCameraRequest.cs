using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SQuestCameraRequest : CVariable
	{
		[Ordinal(0)] [RED("("requestYaw")] 		public CBool RequestYaw { get; set;}

		[Ordinal(0)] [RED("("yaw")] 		public CFloat Yaw { get; set;}

		[Ordinal(0)] [RED("("requestPitch")] 		public CBool RequestPitch { get; set;}

		[Ordinal(0)] [RED("("pitch")] 		public CFloat Pitch { get; set;}

		[Ordinal(0)] [RED("("lookAtTag")] 		public CName LookAtTag { get; set;}

		[Ordinal(0)] [RED("("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(0)] [RED("("requestTimeStamp")] 		public CFloat RequestTimeStamp { get; set;}

		public SQuestCameraRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SQuestCameraRequest(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}