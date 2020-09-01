using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSSceneTimetableScenesEntry : CVariable
	{
		[Ordinal(1)] [RED("("storyScene")] 		public CHandle<CStoryScene> StoryScene { get; set;}

		[Ordinal(2)] [RED("("sceneInputSection")] 		public CString SceneInputSection { get; set;}

		[Ordinal(3)] [RED("("cooldownTime")] 		public CFloat CooldownTime { get; set;}

		[Ordinal(4)] [RED("("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(5)] [RED("("priority")] 		public CEnum<EArbitratorPriorities> Priority { get; set;}

		[Ordinal(6)] [RED("("forceMode")] 		public CEnum<EStorySceneForcingMode> ForceMode { get; set;}

		public CSSceneTimetableScenesEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSSceneTimetableScenesEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}