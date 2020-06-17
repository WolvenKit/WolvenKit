using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFlashRenderTargetCamera : CVariable
	{
		[RED("position")] 		public Vector Position { get; set;}

		[RED("rotation")] 		public EulerAngles Rotation { get; set;}

		[RED("fov")] 		public CFloat Fov { get; set;}

		[RED("zoom")] 		public CFloat Zoom { get; set;}

		public SFlashRenderTargetCamera(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFlashRenderTargetCamera(cr2w);

	}
}