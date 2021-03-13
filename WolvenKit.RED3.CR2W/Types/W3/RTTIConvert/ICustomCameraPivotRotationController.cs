using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ICustomCameraPivotRotationController : ICustomCameraBaseController
	{
		[Ordinal(1)] [RED("minPitch")] 		public CFloat MinPitch { get; set;}

		[Ordinal(2)] [RED("maxPitch")] 		public CFloat MaxPitch { get; set;}

		[Ordinal(3)] [RED("sensitivityPreset")] 		public CEnum<EInputSensitivityPreset> SensitivityPreset { get; set;}

		public ICustomCameraPivotRotationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ICustomCameraPivotRotationController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}