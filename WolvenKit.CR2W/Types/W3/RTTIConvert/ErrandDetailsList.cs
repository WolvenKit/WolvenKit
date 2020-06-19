using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ErrandDetailsList : CVariable
	{
		[RED("errandStringKey")] 		public CString ErrandStringKey { get; set;}

		[RED("newQuestFact")] 		public CString NewQuestFact { get; set;}

		[RED("requiredFact")] 		public CString RequiredFact { get; set;}

		[RED("forbiddenFact")] 		public CString ForbiddenFact { get; set;}

		[RED("addedItemName")] 		public CName AddedItemName { get; set;}

		[RED("displayAsFluff")] 		public CBool DisplayAsFluff { get; set;}

		[RED("posX")] 		public CInt32 PosX { get; set;}

		[RED("posY")] 		public CInt32 PosY { get; set;}

		[RED("errandPosition")] 		public CInt32 ErrandPosition { get; set;}

		public ErrandDetailsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ErrandDetailsList(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}