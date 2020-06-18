using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_NobleDressFix : IAnimDangleConstraint
	{
		[RED("boneNameA")] 		public CString BoneNameA { get; set;}

		[RED("boneNameB")] 		public CString BoneNameB { get; set;}

		[RED("boneAxisA")] 		public CEnum<EAxis> BoneAxisA { get; set;}

		[RED("boneAxisB")] 		public CEnum<EAxis> BoneAxisB { get; set;}

		[RED("boneValueA")] 		public CFloat BoneValueA { get; set;}

		[RED("boneValueB")] 		public CFloat BoneValueB { get; set;}

		public CAnimDangleConstraint_NobleDressFix(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAnimDangleConstraint_NobleDressFix(cr2w);

	}
}