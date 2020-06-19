using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEnvProbeGenParams : CVariable
	{
		[RED("useInInterior")] 		public CBool UseInInterior { get; set;}

		[RED("useInExterior")] 		public CBool UseInExterior { get; set;}

		[RED("isInteriorFallback")] 		public CBool IsInteriorFallback { get; set;}

		[RED("cullingDistance")] 		public CFloat CullingDistance { get; set;}

		[RED("ambientColor")] 		public CColor AmbientColor { get; set;}

		[RED("ambientIntensity")] 		public CFloat AmbientIntensity { get; set;}

		[RED("dimmerFactor")] 		public CFloat DimmerFactor { get; set;}

		[RED("fadeInDuration")] 		public CFloat FadeInDuration { get; set;}

		[RED("fadeOutDuration")] 		public CFloat FadeOutDuration { get; set;}

		[RED("lightScaleGlobal")] 		public CFloat LightScaleGlobal { get; set;}

		[RED("lightScaleLocals")] 		public CFloat LightScaleLocals { get; set;}

		[RED("fogAmount")] 		public CFloat FogAmount { get; set;}

		[RED("daycycleAmbientIntensity")] 		public SSimpleCurve DaycycleAmbientIntensity { get; set;}

		[RED("daycycleLightScaleLocals")] 		public SSimpleCurve DaycycleLightScaleLocals { get; set;}

		[RED("daycycleEffectIntensity")] 		public SSimpleCurve DaycycleEffectIntensity { get; set;}

		public SEnvProbeGenParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEnvProbeGenParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}