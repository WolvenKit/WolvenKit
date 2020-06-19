using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStripeControlPoint : CVariable
	{
		[RED("position")] 		public Vector Position { get; set;}

		[RED("color")] 		public CColor Color { get; set;}

		[RED("scale")] 		public CFloat Scale { get; set;}

		[RED("rotation")] 		public EulerAngles Rotation { get; set;}

		[RED("blendOffset")] 		public CFloat BlendOffset { get; set;}

		public SStripeControlPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStripeControlPoint(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}