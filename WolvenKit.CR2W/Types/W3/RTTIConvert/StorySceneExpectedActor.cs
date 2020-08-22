using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class StorySceneExpectedActor : CVariable
	{
		[RED("voicetag")] 		public CName Voicetag { get; set;}

		[RED("actorTags")] 		public TagList ActorTags { get; set;}

		[RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[RED("appearanceFilter", 2,0)] 		public CArray<CName> AppearanceFilter { get; set;}

		[RED("dontSearchByVoicetag")] 		public CBool DontSearchByVoicetag { get; set;}

		[RED("alias")] 		public CString Alias { get; set;}

		public StorySceneExpectedActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new StorySceneExpectedActor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}