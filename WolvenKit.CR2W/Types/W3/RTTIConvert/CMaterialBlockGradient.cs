using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockGradient : CMaterialBlock
	{
		[RED("gradientType")] 		public EGradientTypes GradientType { get; set;}

		[RED("reverse")] 		public CBool Reverse { get; set;}

		[RED("loop")] 		public CBool Loop { get; set;}

		[RED("offset")] 		public CFloat Offset { get; set;}

		[RED("gradientExtrapolationMode")] 		public EGradientExtrapolationModes GradientExtrapolationMode { get; set;}

		[RED("gradient")] 		public SSimpleCurve Gradient { get; set;}

		public CMaterialBlockGradient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockGradient(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}