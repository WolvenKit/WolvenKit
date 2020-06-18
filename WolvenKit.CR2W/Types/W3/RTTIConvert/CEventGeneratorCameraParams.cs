using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEventGeneratorCameraParams : CVariable
	{
		[RED("cameraPlane")] 		public CEnum<ECameraPlane> CameraPlane { get; set;}

		[RED("tags")] 		public TagList Tags { get; set;}

		[RED("targetSlot")] 		public CInt32 TargetSlot { get; set;}

		[RED("sourceSlot")] 		public CInt32 SourceSlot { get; set;}

		[RED("usableForGenerator")] 		public CBool UsableForGenerator { get; set;}

		public CEventGeneratorCameraParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEventGeneratorCameraParams(cr2w);

	}
}