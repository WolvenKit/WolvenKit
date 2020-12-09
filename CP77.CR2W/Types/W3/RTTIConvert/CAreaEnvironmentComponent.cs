using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAreaEnvironmentComponent : CTriggerAreaComponent
	{
		[Ordinal(1)] [RED("priority")] 		public CInt32 Priority { get; set;}

		[Ordinal(2)] [RED("blendingDistance")] 		public CFloat BlendingDistance { get; set;}

		[Ordinal(3)] [RED("blendingScale")] 		public CFloat BlendingScale { get; set;}

		[Ordinal(4)] [RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		[Ordinal(5)] [RED("blendOutTime")] 		public CFloat BlendOutTime { get; set;}

		[Ordinal(6)] [RED("terrainBlendingDistance")] 		public CFloat TerrainBlendingDistance { get; set;}

		[Ordinal(7)] [RED("blendAboveAndBelow")] 		public CBool BlendAboveAndBelow { get; set;}

		[Ordinal(8)] [RED("rainDropsParticleSystem")] 		public CHandle<CParticleSystem> RainDropsParticleSystem { get; set;}

		[Ordinal(9)] [RED("rainSplashesParticleSystem")] 		public CHandle<CParticleSystem> RainSplashesParticleSystem { get; set;}

		[Ordinal(10)] [RED("additionalEnvEntity")] 		public CHandle<CEntityTemplate> AdditionalEnvEntity { get; set;}

		[Ordinal(11)] [RED("environmentDefinition")] 		public CHandle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

		[Ordinal(12)] [RED("blendingCurveEnabled")] 		public CBool BlendingCurveEnabled { get; set;}

		[Ordinal(13)] [RED("blendingCurve")] 		public SSimpleCurve BlendingCurve { get; set;}

		[Ordinal(14)] [RED("points", 2,0)] 		public CArray<SAreaEnvironmentPoint> Points { get; set;}

		public CAreaEnvironmentComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAreaEnvironmentComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}