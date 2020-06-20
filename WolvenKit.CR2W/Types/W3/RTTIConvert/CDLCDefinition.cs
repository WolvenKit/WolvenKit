using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDLCDefinition : CResource
	{
		[RED("id")] 		public CName Id { get; set;}

		[RED("localizedNameKey")] 		public CString LocalizedNameKey { get; set;}

		[RED("localizedDescriptionKey")] 		public CString LocalizedDescriptionKey { get; set;}

		[RED("mounters", 2,0)] 		public CArray<CPtr<IGameplayDLCMounter>> Mounters { get; set;}

		[RED("languagePacks", 2,0)] 		public CArray<SDLCLanguagePack> LanguagePacks { get; set;}

		[RED("initiallyEnabled")] 		public CBool InitiallyEnabled { get; set;}

		[RED("visibleInDLCMenu")] 		public CBool VisibleInDLCMenu { get; set;}

		[RED("requiredByGameSave")] 		public CBool RequiredByGameSave { get; set;}

		public CDLCDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDLCDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}