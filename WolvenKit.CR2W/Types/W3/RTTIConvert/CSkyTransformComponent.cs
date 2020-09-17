using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkyTransformComponent : CComponent
	{
		[Ordinal(1)] [RED("transformType")] 		public CEnum<ESkyTransformType> TransformType { get; set;}

		[Ordinal(2)] [RED("cameraDistance")] 		public CFloat CameraDistance { get; set;}

		[Ordinal(3)] [RED("uniformScaleDistance")] 		public CFloat UniformScaleDistance { get; set;}

		public CSkyTransformComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkyTransformComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}