using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneActor : IStorySceneItem
	{
		[Ordinal(1)] [RED("id")] 		public CName Id { get; set;}

		[Ordinal(2)] [RED("actorTags")] 		public TagList ActorTags { get; set;}

		[Ordinal(3)] [RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(4)] [RED("appearanceFilter", 2,0)] 		public CArray<CName> AppearanceFilter { get; set;}

		[Ordinal(5)] [RED("dontSearchByVoicetag")] 		public CBool DontSearchByVoicetag { get; set;}

		[Ordinal(6)] [RED("useHiresShadows")] 		public CBool UseHiresShadows { get; set;}

		[Ordinal(7)] [RED("forceSpawn")] 		public CBool ForceSpawn { get; set;}

		[Ordinal(8)] [RED("useMimic")] 		public CBool UseMimic { get; set;}

		[Ordinal(9)] [RED("alias")] 		public CString Alias { get; set;}

		public CStorySceneActor(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}