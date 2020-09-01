using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Hinge : CAnimSkeletalDangleConstraint
	{
		[Ordinal(0)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(0)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(0)] [RED("limit")] 		public CFloat Limit { get; set;}

		[Ordinal(0)] [RED("bounce")] 		public CFloat Bounce { get; set;}

		[Ordinal(0)] [RED("damp")] 		public CFloat Damp { get; set;}

		[Ordinal(0)] [RED("min")] 		public CFloat Min { get; set;}

		[Ordinal(0)] [RED("max")] 		public CFloat Max { get; set;}

		[Ordinal(0)] [RED("inertia")] 		public CFloat Inertia { get; set;}

		[Ordinal(0)] [RED("gravity")] 		public CFloat Gravity { get; set;}

		[Ordinal(0)] [RED("spring")] 		public CFloat Spring { get; set;}

		public CAnimDangleConstraint_Hinge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_Hinge(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}