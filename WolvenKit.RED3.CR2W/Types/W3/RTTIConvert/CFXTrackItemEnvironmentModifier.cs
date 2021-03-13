using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemEnvironmentModifier : CFXTrackItem
	{
		[Ordinal(1)] [RED("lightDirection")] 		public Vector LightDirection { get; set;}

		[Ordinal(2)] [RED("sunLightDiffuse")] 		public CColor SunLightDiffuse { get; set;}

		[Ordinal(3)] [RED("sunLightBrightness")] 		public CFloat SunLightBrightness { get; set;}

		[Ordinal(4)] [RED("ambientOverride")] 		public CColor AmbientOverride { get; set;}

		[Ordinal(5)] [RED("ambientOverrideBrightness")] 		public CFloat AmbientOverrideBrightness { get; set;}

		[Ordinal(6)] [RED("overrideBalancing")] 		public CBool OverrideBalancing { get; set;}

		[Ordinal(7)] [RED("parametricBalanceLow")] 		public CColor ParametricBalanceLow { get; set;}

		[Ordinal(8)] [RED("parametricBalanceLowScale")] 		public CFloat ParametricBalanceLowScale { get; set;}

		[Ordinal(9)] [RED("parametricBalanceMid")] 		public CColor ParametricBalanceMid { get; set;}

		[Ordinal(10)] [RED("parametricBalanceMidScale")] 		public CFloat ParametricBalanceMidScale { get; set;}

		[Ordinal(11)] [RED("parametricBalanceHigh")] 		public CColor ParametricBalanceHigh { get; set;}

		[Ordinal(12)] [RED("parametricBalanceHighScale")] 		public CFloat ParametricBalanceHighScale { get; set;}

		public CFXTrackItemEnvironmentModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItemEnvironmentModifier(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}