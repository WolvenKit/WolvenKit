using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4LootDefinitionBase : CLootDefinitionBase
	{
		[RED("quantityMin")] 		public CUInt32 QuantityMin { get; set;}

		[RED("quantityMax")] 		public CUInt32 QuantityMax { get; set;}

		[RED("playerLevelMin")] 		public CUInt32 PlayerLevelMin { get; set;}

		[RED("playerLevelMax")] 		public CUInt32 PlayerLevelMax { get; set;}

		[RED("crafterLevelMin")] 		public CUInt32 CrafterLevelMin { get; set;}

		[RED("crafterLevelMax")] 		public CUInt32 CrafterLevelMax { get; set;}

		public CR4LootDefinitionBase(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4LootDefinitionBase(cr2w);

	}
}