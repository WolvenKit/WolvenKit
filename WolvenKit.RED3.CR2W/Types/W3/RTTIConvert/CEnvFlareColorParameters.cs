using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvFlareColorParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("color0")] 		public SSimpleCurve Color0 { get; set;}

		[Ordinal(3)] [RED("opacity0")] 		public SSimpleCurve Opacity0 { get; set;}

		[Ordinal(4)] [RED("color1")] 		public SSimpleCurve Color1 { get; set;}

		[Ordinal(5)] [RED("opacity1")] 		public SSimpleCurve Opacity1 { get; set;}

		[Ordinal(6)] [RED("color2")] 		public SSimpleCurve Color2 { get; set;}

		[Ordinal(7)] [RED("opacity2")] 		public SSimpleCurve Opacity2 { get; set;}

		[Ordinal(8)] [RED("color3")] 		public SSimpleCurve Color3 { get; set;}

		[Ordinal(9)] [RED("opacity3")] 		public SSimpleCurve Opacity3 { get; set;}

		public CEnvFlareColorParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvFlareColorParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}