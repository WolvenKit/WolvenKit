using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimItemEvent : CExtAnimEvent
	{
		[RED("category")] 		public CName Category { get; set;}

		[RED("itemName_optional")] 		public CName ItemName_optional { get; set;}

		[RED("action")] 		public CEnum<EItemAction> Action { get; set;}

		[RED("ignoreItemsWithTag")] 		public CName IgnoreItemsWithTag { get; set;}

		[RED("itemGetting")] 		public CEnum<EGettingItem> ItemGetting { get; set;}

		public CExtAnimItemEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimItemEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}