using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneActorTemplate : CVariable
	{
		[RED("template")] 		public CHandle<CEntityTemplate> Template { get; set;}

		[RED("appearances", 2,0)] 		public CArray<CName> Appearances { get; set;}

		[RED("tags")] 		public TagList Tags { get; set;}

		public CStorySceneActorTemplate(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneActorTemplate(cr2w);

	}
}