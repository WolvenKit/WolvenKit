using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurStiffness : CVariable
	{
		[RED("stiffness")] 		public CFloat Stiffness { get; set;}

		[RED("stiffnessStrength")] 		public CFloat StiffnessStrength { get; set;}

		[RED("stiffnessTex")] 		public CHandle<CBitmapTexture> StiffnessTex { get; set;}

		[RED("stiffnessTexChannel")] 		public EHairTextureChannel StiffnessTexChannel { get; set;}

		[RED("interactionStiffness")] 		public CFloat InteractionStiffness { get; set;}

		[RED("pinStiffness")] 		public CFloat PinStiffness { get; set;}

		[RED("rootStiffness")] 		public CFloat RootStiffness { get; set;}

		[RED("rootStiffnessTex")] 		public CHandle<CBitmapTexture> RootStiffnessTex { get; set;}

		[RED("rootStiffnessTexChannel")] 		public EHairTextureChannel RootStiffnessTexChannel { get; set;}

		[RED("stiffnessDamping")] 		public CFloat StiffnessDamping { get; set;}

		[RED("tipStiffness")] 		public CFloat TipStiffness { get; set;}

		[RED("bendStiffness")] 		public CFloat BendStiffness { get; set;}

		[RED("stiffnessBoneEnable")] 		public CBool StiffnessBoneEnable { get; set;}

		[RED("stiffnessBoneIndex")] 		public CUInt32 StiffnessBoneIndex { get; set;}

		[RED("stiffnessBoneAxis")] 		public CUInt32 StiffnessBoneAxis { get; set;}

		[RED("stiffnessStartDistance")] 		public CFloat StiffnessStartDistance { get; set;}

		[RED("stiffnessEndDistance")] 		public CFloat StiffnessEndDistance { get; set;}

		[RED("stiffnessBoneCurve")] 		public Vector StiffnessBoneCurve { get; set;}

		[RED("stiffnessCurve")] 		public Vector StiffnessCurve { get; set;}

		[RED("stiffnessStrengthCurve")] 		public Vector StiffnessStrengthCurve { get; set;}

		[RED("stiffnessDampingCurve")] 		public Vector StiffnessDampingCurve { get; set;}

		[RED("bendStiffnessCurve")] 		public Vector BendStiffnessCurve { get; set;}

		[RED("interactionStiffnessCurve")] 		public Vector InteractionStiffnessCurve { get; set;}

		public SFurStiffness(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFurStiffness(cr2w);

	}
}