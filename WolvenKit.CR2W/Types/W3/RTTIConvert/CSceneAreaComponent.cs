using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSceneAreaComponent : CTriggerAreaComponent
	{
		[RED("sceneSelectionMode")] 		public CEnum<ESceneSelectionMode> SceneSelectionMode { get; set;}

		[RED("scenesPriority")] 		public CEnum<EArbitratorPriorities> ScenesPriority { get; set;}

		[RED("intervalBetweenScenes")] 		public CFloat IntervalBetweenScenes { get; set;}

		[RED("maxConcurrentScenes")] 		public CUInt32 MaxConcurrentScenes { get; set;}

		[RED("scenes", 2,0)] 		public CArray<CScenesTableEntry> Scenes { get; set;}

		[RED("actorsType")] 		public CEnum<ESceneActorType> ActorsType { get; set;}

		public CSceneAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSceneAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}