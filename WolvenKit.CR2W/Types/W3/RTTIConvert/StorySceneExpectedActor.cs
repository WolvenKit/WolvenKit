using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class StorySceneExpectedActor : CVariable
	{
		[Ordinal(1)] [RED("voicetag")] 		public CName Voicetag { get; set;}

		[Ordinal(2)] [RED("actorTags")] 		public TagList ActorTags { get; set;}

		[Ordinal(3)] [RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(4)] [RED("appearanceFilter", 2,0)] 		public CArray<CName> AppearanceFilter { get; set;}

		[Ordinal(5)] [RED("dontSearchByVoicetag")] 		public CBool DontSearchByVoicetag { get; set;}

		[Ordinal(6)] [RED("alias")] 		public CString Alias { get; set;}

		public StorySceneExpectedActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new StorySceneExpectedActor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}