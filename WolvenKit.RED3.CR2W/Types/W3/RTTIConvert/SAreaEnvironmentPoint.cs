using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAreaEnvironmentPoint : CVariable
	{
		[Ordinal(1)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(2)] [RED("direction")] 		public EulerAngles Direction { get; set;}

		[Ordinal(3)] [RED("type")] 		public CEnum<EAreaEnvironmentPointType> Type { get; set;}

		[Ordinal(4)] [RED("blend")] 		public CEnum<EAreaEnvironmentPointBlend> Blend { get; set;}

		[Ordinal(5)] [RED("innerRadius")] 		public CFloat InnerRadius { get; set;}

		[Ordinal(6)] [RED("outerRadius")] 		public CFloat OuterRadius { get; set;}

		[Ordinal(7)] [RED("scaleX")] 		public CFloat ScaleX { get; set;}

		[Ordinal(8)] [RED("scaleY")] 		public CFloat ScaleY { get; set;}

		[Ordinal(9)] [RED("scaleZ")] 		public CFloat ScaleZ { get; set;}

		[Ordinal(10)] [RED("useCurve")] 		public CBool UseCurve { get; set;}

		[Ordinal(11)] [RED("curve")] 		public SSimpleCurve Curve { get; set;}

		[Ordinal(12)] [RED("blendScale")] 		public CFloat BlendScale { get; set;}

		[Ordinal(13)] [RED("environmentDefinition")] 		public CHandle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

		public SAreaEnvironmentPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAreaEnvironmentPoint(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}