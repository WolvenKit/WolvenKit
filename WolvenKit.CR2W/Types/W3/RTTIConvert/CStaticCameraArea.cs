using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStaticCameraArea : CEntity
	{
		[RED("cameraTag")] 		public CName CameraTag { get; set;}

		[RED("onlyForPlayer")] 		public CBool OnlyForPlayer { get; set;}

		[RED("activatorTag")] 		public CName ActivatorTag { get; set;}

		public CStaticCameraArea(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStaticCameraArea(cr2w);

	}
}