using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockGradient : CMaterialBlock
	{
		[Ordinal(1)] [RED("gradientType")] 		public CEnum<EGradientTypes> GradientType { get; set;}

		[Ordinal(2)] [RED("reverse")] 		public CBool Reverse { get; set;}

		[Ordinal(3)] [RED("loop")] 		public CBool Loop { get; set;}

		[Ordinal(4)] [RED("offset")] 		public CFloat Offset { get; set;}

		[Ordinal(5)] [RED("gradientExtrapolationMode")] 		public CEnum<EGradientExtrapolationModes> GradientExtrapolationMode { get; set;}

		[Ordinal(6)] [RED("gradient")] 		public SSimpleCurve Gradient { get; set;}

		public CMaterialBlockGradient(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockGradient(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}