using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvCameraLightsSetupParameters : CVariable
	{
		[Ordinal(1)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("("gameplayLight0")] 		public CEnvCameraLightParameters GameplayLight0 { get; set;}

		[Ordinal(3)] [RED("("gameplayLight1")] 		public CEnvCameraLightParameters GameplayLight1 { get; set;}

		[Ordinal(4)] [RED("("sceneLight0")] 		public CEnvCameraLightParameters SceneLight0 { get; set;}

		[Ordinal(5)] [RED("("sceneLight1")] 		public CEnvCameraLightParameters SceneLight1 { get; set;}

		[Ordinal(6)] [RED("("dialogLight0")] 		public CEnvCameraLightParameters DialogLight0 { get; set;}

		[Ordinal(7)] [RED("("dialogLight1")] 		public CEnvCameraLightParameters DialogLight1 { get; set;}

		[Ordinal(8)] [RED("("interiorLight0")] 		public CEnvCameraLightParameters InteriorLight0 { get; set;}

		[Ordinal(9)] [RED("("interiorLight1")] 		public CEnvCameraLightParameters InteriorLight1 { get; set;}

		[Ordinal(10)] [RED("("playerInInteriorLightsScale")] 		public SSimpleCurve PlayerInInteriorLightsScale { get; set;}

		[Ordinal(11)] [RED("("sceneLightColorInterior0")] 		public SSimpleCurve SceneLightColorInterior0 { get; set;}

		[Ordinal(12)] [RED("("sceneLightColorInterior1")] 		public SSimpleCurve SceneLightColorInterior1 { get; set;}

		[Ordinal(13)] [RED("("cameraLightsNonCharacterScale")] 		public SSimpleCurve CameraLightsNonCharacterScale { get; set;}

		public CEnvCameraLightsSetupParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvCameraLightsSetupParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}