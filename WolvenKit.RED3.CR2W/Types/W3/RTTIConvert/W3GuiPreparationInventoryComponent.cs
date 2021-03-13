using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GuiPreparationInventoryComponent : W3GuiPlayerInventoryComponent
	{
		[Ordinal(1)] [RED("_equippedFilter")] 		public CBool _equippedFilter { get; set;}

		[Ordinal(2)] [RED("_categoryFilter")] 		public CBool _categoryFilter { get; set;}

		[Ordinal(3)] [RED("_categoryFilterValue")] 		public CEnum<EPreporationItemType> _categoryFilterValue { get; set;}

		public W3GuiPreparationInventoryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3GuiPreparationInventoryComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}