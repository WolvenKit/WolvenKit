using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SScenePersonalCameraDescription : CVariable
	{
		[Ordinal(0)] [RED("("cameraName")] 		public CName CameraName { get; set;}

		[Ordinal(0)] [RED("("cameraNumber")] 		public CUInt32 CameraNumber { get; set;}

		[Ordinal(0)] [RED("("targetSlot")] 		public CUInt32 TargetSlot { get; set;}

		[Ordinal(0)] [RED("("sourceSlot")] 		public CUInt32 SourceSlot { get; set;}

		[Ordinal(0)] [RED("("cameraShots", 2,0)] 		public CArray<SSceneCameraShotDescription> CameraShots { get; set;}

		public SScenePersonalCameraDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SScenePersonalCameraDescription(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}