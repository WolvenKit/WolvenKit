using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SInventoryItem : CVariable
	{
		[Ordinal(1)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(2)] [RED("itemQuantity")] 		public CUInt32 ItemQuantity { get; set;}

		[Ordinal(3)] [RED("uniqueId")] 		public SItemUniqueId UniqueId { get; set;}

		[Ordinal(4)] [RED("flags")] 		public CUInt64 Flags { get; set;}

		[Ordinal(5)] [RED("staticRandomSeed")] 		public CUInt16 StaticRandomSeed { get; set;}

		[Ordinal(6)] [RED("uiData")] 		public SInventoryItemUIData UiData { get; set;}

		[Ordinal(7)] [RED("craftedAbilities", 2,0)] 		public CArray<CName> CraftedAbilities { get; set;}

		[Ordinal(8)] [RED("enchantmentName")] 		public CName EnchantmentName { get; set;}

		[Ordinal(9)] [RED("enchantmentStats")] 		public CName EnchantmentStats { get; set;}

		[Ordinal(10)] [RED("dyeColorName")] 		public CName DyeColorName { get; set;}

		[Ordinal(11)] [RED("dyeColorAbilityName")] 		public CName DyeColorAbilityName { get; set;}

		[Ordinal(12)] [RED("dyePreviewColorName")] 		public CName DyePreviewColorName { get; set;}

		public SInventoryItem(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SInventoryItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}