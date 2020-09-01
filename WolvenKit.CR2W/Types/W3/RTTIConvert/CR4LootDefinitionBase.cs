using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4LootDefinitionBase : CLootDefinitionBase
	{
		[Ordinal(1)] [RED("("quantityMin")] 		public CUInt32 QuantityMin { get; set;}

		[Ordinal(2)] [RED("("quantityMax")] 		public CUInt32 QuantityMax { get; set;}

		[Ordinal(3)] [RED("("playerLevelMin")] 		public CUInt32 PlayerLevelMin { get; set;}

		[Ordinal(4)] [RED("("playerLevelMax")] 		public CUInt32 PlayerLevelMax { get; set;}

		[Ordinal(5)] [RED("("crafterLevelMin")] 		public CUInt32 CrafterLevelMin { get; set;}

		[Ordinal(6)] [RED("("crafterLevelMax")] 		public CUInt32 CrafterLevelMax { get; set;}

		public CR4LootDefinitionBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4LootDefinitionBase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}