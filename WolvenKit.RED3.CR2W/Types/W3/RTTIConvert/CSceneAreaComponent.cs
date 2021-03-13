using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSceneAreaComponent : CTriggerAreaComponent
	{
		[Ordinal(1)] [RED("sceneSelectionMode")] 		public CEnum<ESceneSelectionMode> SceneSelectionMode { get; set;}

		[Ordinal(2)] [RED("scenesPriority")] 		public CEnum<EArbitratorPriorities> ScenesPriority { get; set;}

		[Ordinal(3)] [RED("intervalBetweenScenes")] 		public CFloat IntervalBetweenScenes { get; set;}

		[Ordinal(4)] [RED("maxConcurrentScenes")] 		public CUInt32 MaxConcurrentScenes { get; set;}

		[Ordinal(5)] [RED("scenes", 2,0)] 		public CArray<CScenesTableEntry> Scenes { get; set;}

		[Ordinal(6)] [RED("actorsType")] 		public CEnum<ESceneActorType> ActorsType { get; set;}

		public CSceneAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSceneAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}