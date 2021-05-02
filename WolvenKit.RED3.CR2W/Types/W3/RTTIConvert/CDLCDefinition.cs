using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDLCDefinition : CResource
	{
		[Ordinal(1)] [RED("id")] 		public CName Id { get; set;}

		[Ordinal(2)] [RED("localizedNameKey")] 		public CString LocalizedNameKey { get; set;}

		[Ordinal(3)] [RED("localizedDescriptionKey")] 		public CString LocalizedDescriptionKey { get; set;}

		[Ordinal(4)] [RED("mounters", 2,0)] 		public CArray<CPtr<IGameplayDLCMounter>> Mounters { get; set;}

		[Ordinal(5)] [RED("languagePacks", 2,0)] 		public CArray<SDLCLanguagePack> LanguagePacks { get; set;}

		[Ordinal(6)] [RED("initiallyEnabled")] 		public CBool InitiallyEnabled { get; set;}

		[Ordinal(7)] [RED("visibleInDLCMenu")] 		public CBool VisibleInDLCMenu { get; set;}

		[Ordinal(8)] [RED("requiredByGameSave")] 		public CBool RequiredByGameSave { get; set;}

		public CDLCDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}