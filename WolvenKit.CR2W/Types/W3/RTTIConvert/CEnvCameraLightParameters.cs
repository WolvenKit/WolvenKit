using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvCameraLightParameters : CVariable
	{
		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("color")] 		public SSimpleCurve Color { get; set;}

		[Ordinal(0)] [RED("("attenuation")] 		public SSimpleCurve Attenuation { get; set;}

		[Ordinal(0)] [RED("("radius")] 		public SSimpleCurve Radius { get; set;}

		[Ordinal(0)] [RED("("offsetFront")] 		public SSimpleCurve OffsetFront { get; set;}

		[Ordinal(0)] [RED("("offsetRight")] 		public SSimpleCurve OffsetRight { get; set;}

		[Ordinal(0)] [RED("("offsetUp")] 		public SSimpleCurve OffsetUp { get; set;}

		public CEnvCameraLightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvCameraLightParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}