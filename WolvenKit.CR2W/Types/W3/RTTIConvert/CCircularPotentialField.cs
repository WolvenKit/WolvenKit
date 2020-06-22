using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCircularPotentialField : IPotentialField
	{
		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("rangeTop")] 		public CFloat RangeTop { get; set;}

		[RED("rangeBottom")] 		public CFloat RangeBottom { get; set;}

		[RED("origin")] 		public Vector Origin { get; set;}

		[RED("solid")] 		public CBool Solid { get; set;}

		public CCircularPotentialField(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCircularPotentialField(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}