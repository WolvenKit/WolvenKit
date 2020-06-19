using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBooksMinigameManager : CGameplayEntity
	{
		[RED("minigameWonFact")] 		public CString MinigameWonFact { get; set;}

		[RED("bookSlotTags", 2,0)] 		public CArray<CName> BookSlotTags { get; set;}

		[RED("bookTags", 2,0)] 		public CArray<CName> BookTags { get; set;}

		public CBooksMinigameManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBooksMinigameManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}