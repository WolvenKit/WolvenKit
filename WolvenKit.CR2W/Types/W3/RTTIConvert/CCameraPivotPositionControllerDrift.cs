using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraPivotPositionControllerDrift : ICustomCameraScriptedPivotPositionController
	{
		[Ordinal(0)] [RED("("zOffset")] 		public CFloat ZOffset { get; set;}

		[Ordinal(0)] [RED("("originalPosition")] 		public Vector OriginalPosition { get; set;}

		[Ordinal(0)] [RED("("blendSpeed")] 		public CFloat BlendSpeed { get; set;}

		[Ordinal(0)] [RED("("blendOutMult")] 		public CFloat BlendOutMult { get; set;}

		[Ordinal(0)] [RED("("sideDistance")] 		public CFloat SideDistance { get; set;}

		[Ordinal(0)] [RED("("backDistance")] 		public CFloat BackDistance { get; set;}

		[Ordinal(0)] [RED("("upDistance")] 		public CFloat UpDistance { get; set;}

		[Ordinal(0)] [RED("("sideDistanceCur")] 		public CFloat SideDistanceCur { get; set;}

		[Ordinal(0)] [RED("("backDistanceCur")] 		public CFloat BackDistanceCur { get; set;}

		[Ordinal(0)] [RED("("upDistanceCur")] 		public CFloat UpDistanceCur { get; set;}

		[Ordinal(0)] [RED("("sideDistanceBlendSpeed")] 		public CFloat SideDistanceBlendSpeed { get; set;}

		[Ordinal(0)] [RED("("backDistanceBlendSpeed")] 		public CFloat BackDistanceBlendSpeed { get; set;}

		[Ordinal(0)] [RED("("upDistanceBlendSpeed")] 		public CFloat UpDistanceBlendSpeed { get; set;}

		[Ordinal(0)] [RED("("timeToDispMax")] 		public CFloat TimeToDispMax { get; set;}

		[Ordinal(0)] [RED("("timeOfsetCur")] 		public CFloat TimeOfsetCur { get; set;}

		[Ordinal(0)] [RED("("timeCur")] 		public CFloat TimeCur { get; set;}

		public CCameraPivotPositionControllerDrift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraPivotPositionControllerDrift(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}