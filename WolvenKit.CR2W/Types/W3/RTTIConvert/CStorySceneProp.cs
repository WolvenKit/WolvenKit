using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneProp : IStorySceneItem
	{
		[RED("id")] 		public CName Id { get; set;}

		[RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[RED("forceBehaviorGraph")] 		public CName ForceBehaviorGraph { get; set;}

		[RED("resetBehaviorGraph")] 		public CBool ResetBehaviorGraph { get; set;}

		[RED("useMimics")] 		public CBool UseMimics { get; set;}

		public CStorySceneProp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneProp(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}