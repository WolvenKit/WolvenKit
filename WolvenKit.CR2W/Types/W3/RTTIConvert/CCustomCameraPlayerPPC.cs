using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCustomCameraPlayerPPC : ICustomCameraPivotPositionController
	{
		[RED("dampFactor")] 		public CFloat DampFactor { get; set;}

		[RED("smoothZ")] 		public CFloat SmoothZ { get; set;}

		public CCustomCameraPlayerPPC(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCustomCameraPlayerPPC(cr2w);

	}
}