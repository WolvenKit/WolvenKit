using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraPivotPositionControllerDrift : ICustomCameraScriptedPivotPositionController
	{
		[Ordinal(1)] [RED("zOffset")] 		public CFloat ZOffset { get; set;}

		[Ordinal(2)] [RED("originalPosition")] 		public Vector OriginalPosition { get; set;}

		[Ordinal(3)] [RED("blendSpeed")] 		public CFloat BlendSpeed { get; set;}

		[Ordinal(4)] [RED("blendOutMult")] 		public CFloat BlendOutMult { get; set;}

		[Ordinal(5)] [RED("sideDistance")] 		public CFloat SideDistance { get; set;}

		[Ordinal(6)] [RED("backDistance")] 		public CFloat BackDistance { get; set;}

		[Ordinal(7)] [RED("upDistance")] 		public CFloat UpDistance { get; set;}

		[Ordinal(8)] [RED("sideDistanceCur")] 		public CFloat SideDistanceCur { get; set;}

		[Ordinal(9)] [RED("backDistanceCur")] 		public CFloat BackDistanceCur { get; set;}

		[Ordinal(10)] [RED("upDistanceCur")] 		public CFloat UpDistanceCur { get; set;}

		[Ordinal(11)] [RED("sideDistanceBlendSpeed")] 		public CFloat SideDistanceBlendSpeed { get; set;}

		[Ordinal(12)] [RED("backDistanceBlendSpeed")] 		public CFloat BackDistanceBlendSpeed { get; set;}

		[Ordinal(13)] [RED("upDistanceBlendSpeed")] 		public CFloat UpDistanceBlendSpeed { get; set;}

		[Ordinal(14)] [RED("timeToDispMax")] 		public CFloat TimeToDispMax { get; set;}

		[Ordinal(15)] [RED("timeOfsetCur")] 		public CFloat TimeOfsetCur { get; set;}

		[Ordinal(16)] [RED("timeCur")] 		public CFloat TimeCur { get; set;}

		public CCameraPivotPositionControllerDrift(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraPivotPositionControllerDrift(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}