using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurStiffness : CVariable
	{
		[Ordinal(0)] [RED("("stiffness")] 		public CFloat Stiffness { get; set;}

		[Ordinal(0)] [RED("("stiffnessStrength")] 		public CFloat StiffnessStrength { get; set;}

		[Ordinal(0)] [RED("("stiffnessTex")] 		public CHandle<CBitmapTexture> StiffnessTex { get; set;}

		[Ordinal(0)] [RED("("stiffnessTexChannel")] 		public CEnum<EHairTextureChannel> StiffnessTexChannel { get; set;}

		[Ordinal(0)] [RED("("interactionStiffness")] 		public CFloat InteractionStiffness { get; set;}

		[Ordinal(0)] [RED("("pinStiffness")] 		public CFloat PinStiffness { get; set;}

		[Ordinal(0)] [RED("("rootStiffness")] 		public CFloat RootStiffness { get; set;}

		[Ordinal(0)] [RED("("rootStiffnessTex")] 		public CHandle<CBitmapTexture> RootStiffnessTex { get; set;}

		[Ordinal(0)] [RED("("rootStiffnessTexChannel")] 		public CEnum<EHairTextureChannel> RootStiffnessTexChannel { get; set;}

		[Ordinal(0)] [RED("("stiffnessDamping")] 		public CFloat StiffnessDamping { get; set;}

		[Ordinal(0)] [RED("("tipStiffness")] 		public CFloat TipStiffness { get; set;}

		[Ordinal(0)] [RED("("bendStiffness")] 		public CFloat BendStiffness { get; set;}

		[Ordinal(0)] [RED("("stiffnessBoneEnable")] 		public CBool StiffnessBoneEnable { get; set;}

		[Ordinal(0)] [RED("("stiffnessBoneIndex")] 		public CUInt32 StiffnessBoneIndex { get; set;}

		[Ordinal(0)] [RED("("stiffnessBoneAxis")] 		public CUInt32 StiffnessBoneAxis { get; set;}

		[Ordinal(0)] [RED("("stiffnessStartDistance")] 		public CFloat StiffnessStartDistance { get; set;}

		[Ordinal(0)] [RED("("stiffnessEndDistance")] 		public CFloat StiffnessEndDistance { get; set;}

		[Ordinal(0)] [RED("("stiffnessBoneCurve")] 		public Vector StiffnessBoneCurve { get; set;}

		[Ordinal(0)] [RED("("stiffnessCurve")] 		public Vector StiffnessCurve { get; set;}

		[Ordinal(0)] [RED("("stiffnessStrengthCurve")] 		public Vector StiffnessStrengthCurve { get; set;}

		[Ordinal(0)] [RED("("stiffnessDampingCurve")] 		public Vector StiffnessDampingCurve { get; set;}

		[Ordinal(0)] [RED("("bendStiffnessCurve")] 		public Vector BendStiffnessCurve { get; set;}

		[Ordinal(0)] [RED("("interactionStiffnessCurve")] 		public Vector InteractionStiffnessCurve { get; set;}

		public SFurStiffness(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurStiffness(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}