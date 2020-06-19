using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneSpawner : CGameplayEntity
	{
		[RED("storyScene")] 		public CHandle<CStoryScene> StoryScene { get; set;}

		[RED("inputName")] 		public CString InputName { get; set;}

		[RED("useSpawnerLocation")] 		public CBool UseSpawnerLocation { get; set;}

		public CStorySceneSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneSpawner(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}