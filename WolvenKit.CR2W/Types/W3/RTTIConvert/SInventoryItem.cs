using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SInventoryItem : CVariable
	{
		[Ordinal(0)] [RED("("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("("itemQuantity")] 		public CUInt32 ItemQuantity { get; set;}

		[Ordinal(0)] [RED("("uniqueId")] 		public SItemUniqueId UniqueId { get; set;}

		[Ordinal(0)] [RED("("flags")] 		public CUInt64 Flags { get; set;}

		[Ordinal(0)] [RED("("staticRandomSeed")] 		public CUInt16 StaticRandomSeed { get; set;}

		[Ordinal(0)] [RED("("uiData")] 		public SInventoryItemUIData UiData { get; set;}

		[Ordinal(0)] [RED("("craftedAbilities", 2,0)] 		public CArray<CName> CraftedAbilities { get; set;}

		[Ordinal(0)] [RED("("enchantmentName")] 		public CName EnchantmentName { get; set;}

		[Ordinal(0)] [RED("("enchantmentStats")] 		public CName EnchantmentStats { get; set;}

		[Ordinal(0)] [RED("("dyeColorName")] 		public CName DyeColorName { get; set;}

		[Ordinal(0)] [RED("("dyeColorAbilityName")] 		public CName DyeColorAbilityName { get; set;}

		[Ordinal(0)] [RED("("dyePreviewColorName")] 		public CName DyePreviewColorName { get; set;}

		public SInventoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SInventoryItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}