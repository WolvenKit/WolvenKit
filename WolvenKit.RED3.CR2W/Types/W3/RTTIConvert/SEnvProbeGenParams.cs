using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEnvProbeGenParams : CVariable
	{
		[Ordinal(1)] [RED("useInInterior")] 		public CBool UseInInterior { get; set;}

		[Ordinal(2)] [RED("useInExterior")] 		public CBool UseInExterior { get; set;}

		[Ordinal(3)] [RED("isInteriorFallback")] 		public CBool IsInteriorFallback { get; set;}

		[Ordinal(4)] [RED("cullingDistance")] 		public CFloat CullingDistance { get; set;}

		[Ordinal(5)] [RED("ambientColor")] 		public CColor AmbientColor { get; set;}

		[Ordinal(6)] [RED("ambientIntensity")] 		public CFloat AmbientIntensity { get; set;}

		[Ordinal(7)] [RED("dimmerFactor")] 		public CFloat DimmerFactor { get; set;}

		[Ordinal(8)] [RED("fadeInDuration")] 		public CFloat FadeInDuration { get; set;}

		[Ordinal(9)] [RED("fadeOutDuration")] 		public CFloat FadeOutDuration { get; set;}

		[Ordinal(10)] [RED("lightScaleGlobal")] 		public CFloat LightScaleGlobal { get; set;}

		[Ordinal(11)] [RED("lightScaleLocals")] 		public CFloat LightScaleLocals { get; set;}

		[Ordinal(12)] [RED("fogAmount")] 		public CFloat FogAmount { get; set;}

		[Ordinal(13)] [RED("daycycleAmbientIntensity")] 		public SSimpleCurve DaycycleAmbientIntensity { get; set;}

		[Ordinal(14)] [RED("daycycleLightScaleLocals")] 		public SSimpleCurve DaycycleLightScaleLocals { get; set;}

		[Ordinal(15)] [RED("daycycleEffectIntensity")] 		public SSimpleCurve DaycycleEffectIntensity { get; set;}

		public SEnvProbeGenParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEnvProbeGenParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}