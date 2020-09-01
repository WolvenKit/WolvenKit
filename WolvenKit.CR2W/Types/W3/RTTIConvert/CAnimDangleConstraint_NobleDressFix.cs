using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_NobleDressFix : IAnimDangleConstraint
	{
		[Ordinal(0)] [RED("boneNameA")] 		public CString BoneNameA { get; set;}

		[Ordinal(0)] [RED("boneNameB")] 		public CString BoneNameB { get; set;}

		[Ordinal(0)] [RED("boneAxisA")] 		public CEnum<EAxis> BoneAxisA { get; set;}

		[Ordinal(0)] [RED("boneAxisB")] 		public CEnum<EAxis> BoneAxisB { get; set;}

		[Ordinal(0)] [RED("boneValueA")] 		public CFloat BoneValueA { get; set;}

		[Ordinal(0)] [RED("boneValueB")] 		public CFloat BoneValueB { get; set;}

		public CAnimDangleConstraint_NobleDressFix(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_NobleDressFix(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}