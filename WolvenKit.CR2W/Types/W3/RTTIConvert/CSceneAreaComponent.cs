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
		[Ordinal(0)] [RED("("sceneSelectionMode")] 		public CEnum<ESceneSelectionMode> SceneSelectionMode { get; set;}

		[Ordinal(0)] [RED("("scenesPriority")] 		public CEnum<EArbitratorPriorities> ScenesPriority { get; set;}

		[Ordinal(0)] [RED("("intervalBetweenScenes")] 		public CFloat IntervalBetweenScenes { get; set;}

		[Ordinal(0)] [RED("("maxConcurrentScenes")] 		public CUInt32 MaxConcurrentScenes { get; set;}

		[Ordinal(0)] [RED("("scenes", 2,0)] 		public CArray<CScenesTableEntry> Scenes { get; set;}

		[Ordinal(0)] [RED("("actorsType")] 		public CEnum<ESceneActorType> ActorsType { get; set;}

		public CSceneAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSceneAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}