using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3UsableItem : CItemEntity
	{
		[Ordinal(0)] [RED("("itemType")] 		public CEnum<EUsableItemType> ItemType { get; set;}

		[Ordinal(0)] [RED("("blockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> BlockedActions { get; set;}

		[Ordinal(0)] [RED("("wasOnHiddenCalled")] 		public CBool WasOnHiddenCalled { get; set;}

		public W3UsableItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3UsableItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}