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
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("activatedBalanceMap")] 		public CBool ActivatedBalanceMap { get; set;}

		[RED("activatedParametricBalance")] 		public CBool ActivatedParametricBalance { get; set;}

		[RED("vignetteWeights")] 		public SSimpleCurve VignetteWeights { get; set;}

		[RED("vignetteColor")] 		public SSimpleCurve VignetteColor { get; set;}

		[RED("vignetteOpacity")] 		public SSimpleCurve VignetteOpacity { get; set;}

		[RED("chromaticAberrationSize")] 		public SSimpleCurve ChromaticAberrationSize { get; set;}

		[RED("balanceMapLerp")] 		public SSimpleCurve BalanceMapLerp { get; set;}

		[RED("balanceMapAmount")] 		public SSimpleCurve BalanceMapAmount { get; set;}

		[RED("balanceMap0")] 		public CSoft<CBitmapTexture> BalanceMap0 { get; set;}

		[RED("balanceMap1")] 		public CSoft<CBitmapTexture> BalanceMap1 { get; set;}

		[RED("balancePostBrightness")] 		public SSimpleCurve BalancePostBrightness { get; set;}

		[RED("levelsShadows")] 		public SSimpleCurve LevelsShadows { get; set;}

		[RED("levelsMidtones")] 		public SSimpleCurve LevelsMidtones { get; set;}

		[RED("levelsHighlights")] 		public SSimpleCurve LevelsHighlights { get; set;}

		[RED("midtoneRangeMin")] 		public SSimpleCurve MidtoneRangeMin { get; set;}

		[RED("midtoneRangeMax")] 		public SSimpleCurve MidtoneRangeMax { get; set;}

		[RED("midtoneMarginMin")] 		public SSimpleCurve MidtoneMarginMin { get; set;}

		[RED("midtoneMarginMax")] 		public SSimpleCurve MidtoneMarginMax { get; set;}

		[RED("parametricBalanceLow")] 		public CEnvParametricBalanceParameters ParametricBalanceLow { get; set;}

		[RED("parametricBalanceMid")] 		public CEnvParametricBalanceParameters ParametricBalanceMid { get; set;}

		[RED("parametricBalanceHigh")] 		public CEnvParametricBalanceParameters ParametricBalanceHigh { get; set;}

		public CEnvFinalColorBalanceParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvFinalColorBalanceParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}