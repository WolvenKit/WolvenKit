using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraPivotPositionControllerDrift : ICustomCameraScriptedPivotPositionController
	{
		[RED("zOffset")] 		public CFloat ZOffset { get; set;}

		[RED("blendSpeed")] 		public CFloat BlendSpeed { get; set;}

		[RED("blendOutMult")] 		public CFloat BlendOutMult { get; set;}

		[RED("sideDistance")] 		public CFloat SideDistance { get; set;}

		[RED("backDistance")] 		public CFloat BackDistance { get; set;}

		[RED("upDistance")] 		public CFloat UpDistance { get; set;}

		[RED("sideDistanceCur")] 		public CFloat SideDistanceCur { get; set;}

		[RED("backDistanceCur")] 		public CFloat BackDistanceCur { get; set;}

		[RED("upDistanceCur")] 		public CFloat UpDistanceCur { get; set;}

		[RED("sideDistanceBlendSpeed")] 		public CFloat SideDistanceBlendSpeed { get; set;}

		[RED("backDistanceBlendSpeed")] 		public CFloat BackDistanceBlendSpeed { get; set;}

		[RED("upDistanceBlendSpeed")] 		public CFloat UpDistanceBlendSpeed { get; set;}

		[RED("timeToDispMax")] 		public CFloat TimeToDispMax { get; set;}

		public CCameraPivotPositionControllerDrift(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCameraPivotPositionControllerDrift(cr2w);

	}
}