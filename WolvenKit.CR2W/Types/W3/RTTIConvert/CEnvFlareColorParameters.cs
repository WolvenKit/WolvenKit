using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvFlareColorParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("color0")] 		public SSimpleCurve Color0 { get; set;}

		[RED("opacity0")] 		public SSimpleCurve Opacity0 { get; set;}

		[RED("color1")] 		public SSimpleCurve Color1 { get; set;}

		[RED("opacity1")] 		public SSimpleCurve Opacity1 { get; set;}

		[RED("color2")] 		public SSimpleCurve Color2 { get; set;}

		[RED("opacity2")] 		public SSimpleCurve Opacity2 { get; set;}

		[RED("color3")] 		public SSimpleCurve Color3 { get; set;}

		[RED("opacity3")] 		public SSimpleCurve Opacity3 { get; set;}

		public CEnvFlareColorParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvFlareColorParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}