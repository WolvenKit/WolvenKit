using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBookMinigameSlot : CGameplayEntity
	{
		[Ordinal(1)] [RED("bookMinigameManagerTag")] 		public CName BookMinigameManagerTag { get; set;}

		[Ordinal(2)] [RED("correctBookId")] 		public CInt32 CorrectBookId { get; set;}

		[Ordinal(3)] [RED("currentBook")] 		public CHandle<CBookMinigameBook> CurrentBook { get; set;}

		[Ordinal(4)] [RED("bookMinigameManager")] 		public CHandle<CBooksMinigameManager> BookMinigameManager { get; set;}

		public CBookMinigameSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBookMinigameSlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}