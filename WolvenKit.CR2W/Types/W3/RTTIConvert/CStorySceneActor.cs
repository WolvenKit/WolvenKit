using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneActor : IStorySceneItem
	{
		[Ordinal(0)] [RED("("id")] 		public CName Id { get; set;}

		[Ordinal(0)] [RED("("actorTags")] 		public TagList ActorTags { get; set;}

		[Ordinal(0)] [RED("("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("("appearanceFilter", 2,0)] 		public CArray<CName> AppearanceFilter { get; set;}

		[Ordinal(0)] [RED("("dontSearchByVoicetag")] 		public CBool DontSearchByVoicetag { get; set;}

		[Ordinal(0)] [RED("("useHiresShadows")] 		public CBool UseHiresShadows { get; set;}

		[Ordinal(0)] [RED("("forceSpawn")] 		public CBool ForceSpawn { get; set;}

		[Ordinal(0)] [RED("("useMimic")] 		public CBool UseMimic { get; set;}

		[Ordinal(0)] [RED("("alias")] 		public CString Alias { get; set;}

		public CStorySceneActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneActor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}