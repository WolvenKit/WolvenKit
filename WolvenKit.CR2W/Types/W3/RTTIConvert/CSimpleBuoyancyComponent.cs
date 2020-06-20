using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSimpleBuoyancyComponent : CComponent
	{
		[RED("waterOffset")] 		public CFloat WaterOffset { get; set;}

		[RED("linearDamping")] 		public CFloat LinearDamping { get; set;}

		[RED("pointFront")] 		public Vector PointFront { get; set;}

		[RED("pointBack")] 		public Vector PointBack { get; set;}

		[RED("pointLeft")] 		public Vector PointLeft { get; set;}

		[RED("pointRight")] 		public Vector PointRight { get; set;}

		public CSimpleBuoyancyComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSimpleBuoyancyComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}