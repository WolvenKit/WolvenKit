using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneProp : IStorySceneItem
	{
		[Ordinal(1)] [RED("id")] 		public CName Id { get; set;}

		[Ordinal(2)] [RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(3)] [RED("forceBehaviorGraph")] 		public CName ForceBehaviorGraph { get; set;}

		[Ordinal(4)] [RED("resetBehaviorGraph")] 		public CBool ResetBehaviorGraph { get; set;}

		[Ordinal(5)] [RED("useMimics")] 		public CBool UseMimics { get; set;}

		public CStorySceneProp(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}