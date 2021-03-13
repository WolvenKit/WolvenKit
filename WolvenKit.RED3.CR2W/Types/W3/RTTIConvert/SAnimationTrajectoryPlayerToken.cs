using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationTrajectoryPlayerToken : CVariable
	{
		[Ordinal(1)] [RED("isValid")] 		public CBool IsValid { get; set;}

		[Ordinal(2)] [RED("pointWS")] 		public Vector PointWS { get; set;}

		[Ordinal(3)] [RED("syncPointMS")] 		public Vector SyncPointMS { get; set;}

		[Ordinal(4)] [RED("timeFactor")] 		public CFloat TimeFactor { get; set;}

		[Ordinal(5)] [RED("syncPointDuration")] 		public CFloat SyncPointDuration { get; set;}

		[Ordinal(6)] [RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[Ordinal(7)] [RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[Ordinal(8)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(9)] [RED("syncTime")] 		public CFloat SyncTime { get; set;}

		public SAnimationTrajectoryPlayerToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationTrajectoryPlayerToken(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}