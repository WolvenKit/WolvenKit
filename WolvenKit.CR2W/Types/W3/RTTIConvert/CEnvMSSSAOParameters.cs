using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvMSSSAOParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("noiseFilterTolerance")] 		public SSimpleCurve NoiseFilterTolerance { get; set;}

		[RED("blurTolerance")] 		public SSimpleCurve BlurTolerance { get; set;}

		[RED("upsampleTolerance")] 		public SSimpleCurve UpsampleTolerance { get; set;}

		[RED("rejectionFalloff")] 		public SSimpleCurve RejectionFalloff { get; set;}

		[RED("combineResolutionsBeforeBlur")] 		public CBool CombineResolutionsBeforeBlur { get; set;}

		[RED("combineResolutionsWithMul")] 		public CBool CombineResolutionsWithMul { get; set;}

		[RED("hierarchyDepth")] 		public SSimpleCurve HierarchyDepth { get; set;}

		[RED("normalAOMultiply")] 		public SSimpleCurve NormalAOMultiply { get; set;}

		[RED("normalToDepthBrightnessEqualiser")] 		public SSimpleCurve NormalToDepthBrightnessEqualiser { get; set;}

		[RED("normalBackProjectionTolerance")] 		public SSimpleCurve NormalBackProjectionTolerance { get; set;}

		public CEnvMSSSAOParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvMSSSAOParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}