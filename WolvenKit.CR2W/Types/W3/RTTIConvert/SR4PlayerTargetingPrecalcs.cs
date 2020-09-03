using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SR4PlayerTargetingPrecalcs : CVariable
	{
		[Ordinal(1)] [RED("playerPosition")] 		public Vector PlayerPosition { get; set;}

		[Ordinal(2)] [RED("playerHeading")] 		public CFloat PlayerHeading { get; set;}

		[Ordinal(3)] [RED("playerHeadingVector")] 		public Vector PlayerHeadingVector { get; set;}

		[Ordinal(4)] [RED("playerRadius")] 		public CFloat PlayerRadius { get; set;}

		[Ordinal(5)] [RED("cameraPosition")] 		public Vector CameraPosition { get; set;}

		[Ordinal(6)] [RED("cameraDirection")] 		public Vector CameraDirection { get; set;}

		[Ordinal(7)] [RED("cameraHeading")] 		public CFloat CameraHeading { get; set;}

		[Ordinal(8)] [RED("cameraHeadingVector")] 		public Vector CameraHeadingVector { get; set;}

		public SR4PlayerTargetingPrecalcs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SR4PlayerTargetingPrecalcs(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}