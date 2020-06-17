using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAreaEnvironmentComponent : CTriggerAreaComponent
	{
		[RED("priority")] 		public CInt32 Priority { get; set;}

		[RED("blendingDistance")] 		public CFloat BlendingDistance { get; set;}

		[RED("blendingScale")] 		public CFloat BlendingScale { get; set;}

		[RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[RED("blendOutTime")] 		public CFloat BlendOutTime { get; set;}

		[RED("terrainBlendingDistance")] 		public CFloat TerrainBlendingDistance { get; set;}

		[RED("blendAboveAndBelow")] 		public CBool BlendAboveAndBelow { get; set;}

		[RED("rainDropsParticleSystem")] 		public CHandle<CParticleSystem> RainDropsParticleSystem { get; set;}

		[RED("rainSplashesParticleSystem")] 		public CHandle<CParticleSystem> RainSplashesParticleSystem { get; set;}

		[RED("additionalEnvEntity")] 		public CHandle<CEntityTemplate> AdditionalEnvEntity { get; set;}

		[RED("environmentDefinition")] 		public CHandle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

		[RED("blendingCurveEnabled")] 		public CBool BlendingCurveEnabled { get; set;}

		[RED("blendingCurve")] 		public SSimpleCurve BlendingCurve { get; set;}

		[RED("points", 2,0)] 		public CArray<SAreaEnvironmentPoint> Points { get; set;}

		public CAreaEnvironmentComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAreaEnvironmentComponent(cr2w);

	}
}