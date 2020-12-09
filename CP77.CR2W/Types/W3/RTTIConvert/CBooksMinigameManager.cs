using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBooksMinigameManager : CGameplayEntity
	{
		[Ordinal(1)] [RED("minigameWonFact")] 		public CString MinigameWonFact { get; set;}

		[Ordinal(2)] [RED("bookSlotTags", 2,0)] 		public CArray<CName> BookSlotTags { get; set;}

		[Ordinal(3)] [RED("bookTags", 2,0)] 		public CArray<CName> BookTags { get; set;}

		[Ordinal(4)] [RED("bookSlots", 2,0)] 		public CArray<CHandle<CBookMinigameSlot>> BookSlots { get; set;}

		[Ordinal(5)] [RED("books", 2,0)] 		public CArray<CHandle<CBookMinigameBook>> Books { get; set;}

		public CBooksMinigameManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBooksMinigameManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}