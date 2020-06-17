using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventCameraLight : CStorySceneEvent
	{
		[RED("cameralightType")] 		public ECameraLightModType CameralightType { get; set;}

		[RED("lightMod1")] 		public SStorySceneCameraLightMod LightMod1 { get; set;}

		[RED("lightMod2")] 		public SStorySceneCameraLightMod LightMod2 { get; set;}

		public CStorySceneEventCameraLight(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventCameraLight(cr2w);

	}
}