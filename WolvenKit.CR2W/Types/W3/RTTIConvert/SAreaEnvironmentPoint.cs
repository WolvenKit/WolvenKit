using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAreaEnvironmentPoint : CVariable
	{
		[RED("position")] 		public Vector Position { get; set;}

		[RED("direction")] 		public EulerAngles Direction { get; set;}

		[RED("type")] 		public CEnum<EAreaEnvironmentPointType> Type { get; set;}

		[RED("blend")] 		public CEnum<EAreaEnvironmentPointBlend> Blend { get; set;}

		[RED("innerRadius")] 		public CFloat InnerRadius { get; set;}

		[RED("outerRadius")] 		public CFloat OuterRadius { get; set;}

		[RED("scaleX")] 		public CFloat ScaleX { get; set;}

		[RED("scaleY")] 		public CFloat ScaleY { get; set;}

		[RED("scaleZ")] 		public CFloat ScaleZ { get; set;}

		[RED("useCurve")] 		public CBool UseCurve { get; set;}

		[RED("curve")] 		public SSimpleCurve Curve { get; set;}

		[RED("blendScale")] 		public CFloat BlendScale { get; set;}

		[RED("environmentDefinition")] 		public CHandle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

		public SAreaEnvironmentPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAreaEnvironmentPoint(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}