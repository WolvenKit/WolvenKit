using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SR4PlayerTargetingPrecalcs : CVariable
	{
		[RED("playerPosition")] 		public Vector PlayerPosition { get; set;}

		[RED("playerHeading")] 		public CFloat PlayerHeading { get; set;}

		[RED("playerHeadingVector")] 		public Vector PlayerHeadingVector { get; set;}

		[RED("playerRadius")] 		public CFloat PlayerRadius { get; set;}

		[RED("cameraPosition")] 		public Vector CameraPosition { get; set;}

		[RED("cameraDirection")] 		public Vector CameraDirection { get; set;}

		[RED("cameraHeading")] 		public CFloat CameraHeading { get; set;}

		[RED("cameraHeadingVector")] 		public Vector CameraHeadingVector { get; set;}

		public SR4PlayerTargetingPrecalcs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SR4PlayerTargetingPrecalcs(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}