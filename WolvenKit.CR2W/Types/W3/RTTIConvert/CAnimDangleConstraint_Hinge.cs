using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Hinge : CAnimSkeletalDangleConstraint
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("limit")] 		public CFloat Limit { get; set;}

		[RED("bounce")] 		public CFloat Bounce { get; set;}

		[RED("damp")] 		public CFloat Damp { get; set;}

		[RED("min")] 		public CFloat Min { get; set;}

		[RED("max")] 		public CFloat Max { get; set;}

		[RED("inertia")] 		public CFloat Inertia { get; set;}

		[RED("gravity")] 		public CFloat Gravity { get; set;}

		[RED("spring")] 		public CFloat Spring { get; set;}

		public CAnimDangleConstraint_Hinge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_Hinge(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}