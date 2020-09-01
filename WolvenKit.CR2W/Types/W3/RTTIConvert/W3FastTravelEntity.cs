using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FastTravelEntity : CR4FastTravelEntity
	{
		[Ordinal(1)] [RED("onAreaExit")] 		public CBool OnAreaExit { get; set;}

		[Ordinal(2)] [RED("warningTextStringKeyOverride")] 		public CString WarningTextStringKeyOverride { get; set;}

		[Ordinal(3)] [RED("onelinerSceneOverride")] 		public CHandle<CStoryScene> OnelinerSceneOverride { get; set;}

		[Ordinal(4)] [RED("overrideSceneInput")] 		public CName OverrideSceneInput { get; set;}

		public W3FastTravelEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FastTravelEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}