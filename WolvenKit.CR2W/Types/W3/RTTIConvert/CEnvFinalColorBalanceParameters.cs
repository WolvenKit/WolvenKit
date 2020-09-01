using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvFinalColorBalanceParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("activatedBalanceMap")] 		public CBool ActivatedBalanceMap { get; set;}

		[Ordinal(3)] [RED("activatedParametricBalance")] 		public CBool ActivatedParametricBalance { get; set;}

		[Ordinal(4)] [RED("vignetteWeights")] 		public SSimpleCurve VignetteWeights { get; set;}

		[Ordinal(5)] [RED("vignetteColor")] 		public SSimpleCurve VignetteColor { get; set;}

		[Ordinal(6)] [RED("vignetteOpacity")] 		public SSimpleCurve VignetteOpacity { get; set;}

		[Ordinal(7)] [RED("chromaticAberrationSize")] 		public SSimpleCurve ChromaticAberrationSize { get; set;}

		[Ordinal(8)] [RED("balanceMapLerp")] 		public SSimpleCurve BalanceMapLerp { get; set;}

		[Ordinal(9)] [RED("balanceMapAmount")] 		public SSimpleCurve BalanceMapAmount { get; set;}

		[Ordinal(10)] [RED("balanceMap0")] 		public CSoft<CBitmapTexture> BalanceMap0 { get; set;}

		[Ordinal(11)] [RED("balanceMap1")] 		public CSoft<CBitmapTexture> BalanceMap1 { get; set;}

		[Ordinal(12)] [RED("balancePostBrightness")] 		public SSimpleCurve BalancePostBrightness { get; set;}

		[Ordinal(13)] [RED("levelsShadows")] 		public SSimpleCurve LevelsShadows { get; set;}

		[Ordinal(14)] [RED("levelsMidtones")] 		public SSimpleCurve LevelsMidtones { get; set;}

		[Ordinal(15)] [RED("levelsHighlights")] 		public SSimpleCurve LevelsHighlights { get; set;}

		[Ordinal(16)] [RED("midtoneRangeMin")] 		public SSimpleCurve MidtoneRangeMin { get; set;}

		[Ordinal(17)] [RED("midtoneRangeMax")] 		public SSimpleCurve MidtoneRangeMax { get; set;}

		[Ordinal(18)] [RED("midtoneMarginMin")] 		public SSimpleCurve MidtoneMarginMin { get; set;}

		[Ordinal(19)] [RED("midtoneMarginMax")] 		public SSimpleCurve MidtoneMarginMax { get; set;}

		[Ordinal(20)] [RED("parametricBalanceLow")] 		public CEnvParametricBalanceParameters ParametricBalanceLow { get; set;}

		[Ordinal(21)] [RED("parametricBalanceMid")] 		public CEnvParametricBalanceParameters ParametricBalanceMid { get; set;}

		[Ordinal(22)] [RED("parametricBalanceHigh")] 		public CEnvParametricBalanceParameters ParametricBalanceHigh { get; set;}

		public CEnvFinalColorBalanceParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvFinalColorBalanceParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}