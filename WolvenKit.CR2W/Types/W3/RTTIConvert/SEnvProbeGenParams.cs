using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEnvProbeGenParams : CVariable
	{
		[Ordinal(0)] [RED("("useInInterior")] 		public CBool UseInInterior { get; set;}

		[Ordinal(0)] [RED("("useInExterior")] 		public CBool UseInExterior { get; set;}

		[Ordinal(0)] [RED("("isInteriorFallback")] 		public CBool IsInteriorFallback { get; set;}

		[Ordinal(0)] [RED("("cullingDistance")] 		public CFloat CullingDistance { get; set;}

		[Ordinal(0)] [RED("("ambientColor")] 		public CColor AmbientColor { get; set;}

		[Ordinal(0)] [RED("("ambientIntensity")] 		public CFloat AmbientIntensity { get; set;}

		[Ordinal(0)] [RED("("dimmerFactor")] 		public CFloat DimmerFactor { get; set;}

		[Ordinal(0)] [RED("("fadeInDuration")] 		public CFloat FadeInDuration { get; set;}

		[Ordinal(0)] [RED("("fadeOutDuration")] 		public CFloat FadeOutDuration { get; set;}

		[Ordinal(0)] [RED("("lightScaleGlobal")] 		public CFloat LightScaleGlobal { get; set;}

		[Ordinal(0)] [RED("("lightScaleLocals")] 		public CFloat LightScaleLocals { get; set;}

		[Ordinal(0)] [RED("("fogAmount")] 		public CFloat FogAmount { get; set;}

		[Ordinal(0)] [RED("("daycycleAmbientIntensity")] 		public SSimpleCurve DaycycleAmbientIntensity { get; set;}

		[Ordinal(0)] [RED("("daycycleLightScaleLocals")] 		public SSimpleCurve DaycycleLightScaleLocals { get; set;}

		[Ordinal(0)] [RED("("daycycleEffectIntensity")] 		public SSimpleCurve DaycycleEffectIntensity { get; set;}

		public SEnvProbeGenParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEnvProbeGenParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}