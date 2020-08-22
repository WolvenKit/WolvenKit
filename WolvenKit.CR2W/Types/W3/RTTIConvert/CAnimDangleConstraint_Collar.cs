using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Collar : CAnimSkeletalDangleConstraint
	{
		[RED("offset")] 		public Vector Offset { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("offset2")] 		public Vector Offset2 { get; set;}

		[RED("radius2")] 		public CFloat Radius2 { get; set;}

		public CAnimDangleConstraint_Collar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_Collar(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}