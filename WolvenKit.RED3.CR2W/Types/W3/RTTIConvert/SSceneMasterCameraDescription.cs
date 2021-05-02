using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSceneMasterCameraDescription : CVariable
	{
		[Ordinal(1)] [RED("cameraName")] 		public CName CameraName { get; set;}

		[Ordinal(2)] [RED("cameraNumber")] 		public CUInt32 CameraNumber { get; set;}

		[Ordinal(3)] [RED("cameraShots", 2,0)] 		public CArray<SSceneCameraShotDescription> CameraShots { get; set;}

		public SSceneMasterCameraDescription(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}