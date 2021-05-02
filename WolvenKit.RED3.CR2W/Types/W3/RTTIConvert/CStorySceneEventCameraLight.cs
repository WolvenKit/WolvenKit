using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventCameraLight : CStorySceneEvent
	{
		[Ordinal(1)] [RED("cameralightType")] 		public CEnum<ECameraLightModType> CameralightType { get; set;}

		[Ordinal(2)] [RED("lightMod1")] 		public SStorySceneCameraLightMod LightMod1 { get; set;}

		[Ordinal(3)] [RED("lightMod2")] 		public SStorySceneCameraLightMod LightMod2 { get; set;}

		public CStorySceneEventCameraLight(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}