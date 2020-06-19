using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationTrajectoryPlayerToken : CVariable
	{
		[RED("isValid")] 		public CBool IsValid { get; set;}

		[RED("pointWS")] 		public Vector PointWS { get; set;}

		[RED("syncPointMS")] 		public Vector SyncPointMS { get; set;}

		[RED("timeFactor")] 		public CFloat TimeFactor { get; set;}

		[RED("syncPointDuration")] 		public CFloat SyncPointDuration { get; set;}

		[RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("syncTime")] 		public CFloat SyncTime { get; set;}

		public SAnimationTrajectoryPlayerToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationTrajectoryPlayerToken(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}