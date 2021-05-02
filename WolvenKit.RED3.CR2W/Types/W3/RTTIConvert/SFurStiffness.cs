using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurStiffness : CVariable
	{
		[Ordinal(1)] [RED("stiffness")] 		public CFloat Stiffness { get; set;}

		[Ordinal(2)] [RED("stiffnessStrength")] 		public CFloat StiffnessStrength { get; set;}

		[Ordinal(3)] [RED("stiffnessTex")] 		public CHandle<CBitmapTexture> StiffnessTex { get; set;}

		[Ordinal(4)] [RED("stiffnessTexChannel")] 		public CEnum<EHairTextureChannel> StiffnessTexChannel { get; set;}

		[Ordinal(5)] [RED("interactionStiffness")] 		public CFloat InteractionStiffness { get; set;}

		[Ordinal(6)] [RED("pinStiffness")] 		public CFloat PinStiffness { get; set;}

		[Ordinal(7)] [RED("rootStiffness")] 		public CFloat RootStiffness { get; set;}

		[Ordinal(8)] [RED("rootStiffnessTex")] 		public CHandle<CBitmapTexture> RootStiffnessTex { get; set;}

		[Ordinal(9)] [RED("rootStiffnessTexChannel")] 		public CEnum<EHairTextureChannel> RootStiffnessTexChannel { get; set;}

		[Ordinal(10)] [RED("stiffnessDamping")] 		public CFloat StiffnessDamping { get; set;}

		[Ordinal(11)] [RED("tipStiffness")] 		public CFloat TipStiffness { get; set;}

		[Ordinal(12)] [RED("bendStiffness")] 		public CFloat BendStiffness { get; set;}

		[Ordinal(13)] [RED("stiffnessBoneEnable")] 		public CBool StiffnessBoneEnable { get; set;}

		[Ordinal(14)] [RED("stiffnessBoneIndex")] 		public CUInt32 StiffnessBoneIndex { get; set;}

		[Ordinal(15)] [RED("stiffnessBoneAxis")] 		public CUInt32 StiffnessBoneAxis { get; set;}

		[Ordinal(16)] [RED("stiffnessStartDistance")] 		public CFloat StiffnessStartDistance { get; set;}

		[Ordinal(17)] [RED("stiffnessEndDistance")] 		public CFloat StiffnessEndDistance { get; set;}

		[Ordinal(18)] [RED("stiffnessBoneCurve")] 		public Vector StiffnessBoneCurve { get; set;}

		[Ordinal(19)] [RED("stiffnessCurve")] 		public Vector StiffnessCurve { get; set;}

		[Ordinal(20)] [RED("stiffnessStrengthCurve")] 		public Vector StiffnessStrengthCurve { get; set;}

		[Ordinal(21)] [RED("stiffnessDampingCurve")] 		public Vector StiffnessDampingCurve { get; set;}

		[Ordinal(22)] [RED("bendStiffnessCurve")] 		public Vector BendStiffnessCurve { get; set;}

		[Ordinal(23)] [RED("interactionStiffnessCurve")] 		public Vector InteractionStiffnessCurve { get; set;}

		public SFurStiffness(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurStiffness(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}