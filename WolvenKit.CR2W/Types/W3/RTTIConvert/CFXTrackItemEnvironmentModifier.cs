using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemEnvironmentModifier : CFXTrackItem
	{
		[Ordinal(0)] [RED("lightDirection")] 		public Vector LightDirection { get; set;}

		[Ordinal(0)] [RED("sunLightDiffuse")] 		public CColor SunLightDiffuse { get; set;}

		[Ordinal(0)] [RED("sunLightBrightness")] 		public CFloat SunLightBrightness { get; set;}

		[Ordinal(0)] [RED("ambientOverride")] 		public CColor AmbientOverride { get; set;}

		[Ordinal(0)] [RED("ambientOverrideBrightness")] 		public CFloat AmbientOverrideBrightness { get; set;}

		[Ordinal(0)] [RED("overrideBalancing")] 		public CBool OverrideBalancing { get; set;}

		[Ordinal(0)] [RED("parametricBalanceLow")] 		public CColor ParametricBalanceLow { get; set;}

		[Ordinal(0)] [RED("parametricBalanceLowScale")] 		public CFloat ParametricBalanceLowScale { get; set;}

		[Ordinal(0)] [RED("parametricBalanceMid")] 		public CColor ParametricBalanceMid { get; set;}

		[Ordinal(0)] [RED("parametricBalanceMidScale")] 		public CFloat ParametricBalanceMidScale { get; set;}

		[Ordinal(0)] [RED("parametricBalanceHigh")] 		public CColor ParametricBalanceHigh { get; set;}

		[Ordinal(0)] [RED("parametricBalanceHighScale")] 		public CFloat ParametricBalanceHighScale { get; set;}

		public CFXTrackItemEnvironmentModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItemEnvironmentModifier(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}