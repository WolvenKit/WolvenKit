using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPlayerOffenseStats : CVariable
	{
		[RED("steelFastDmg")] 		public CFloat SteelFastDmg { get; set;}

		[RED("steelFastCritChance")] 		public CFloat SteelFastCritChance { get; set;}

		[RED("steelFastCritDmg")] 		public CFloat SteelFastCritDmg { get; set;}

		[RED("steelFastDPS")] 		public CFloat SteelFastDPS { get; set;}

		[RED("steelStrongDmg")] 		public CFloat SteelStrongDmg { get; set;}

		[RED("steelStrongCritChance")] 		public CFloat SteelStrongCritChance { get; set;}

		[RED("steelStrongCritDmg")] 		public CFloat SteelStrongCritDmg { get; set;}

		[RED("steelStrongDPS")] 		public CFloat SteelStrongDPS { get; set;}

		[RED("silverFastDmg")] 		public CFloat SilverFastDmg { get; set;}

		[RED("silverFastCritChance")] 		public CFloat SilverFastCritChance { get; set;}

		[RED("silverFastCritDmg")] 		public CFloat SilverFastCritDmg { get; set;}

		[RED("silverFastDPS")] 		public CFloat SilverFastDPS { get; set;}

		[RED("silverStrongDmg")] 		public CFloat SilverStrongDmg { get; set;}

		[RED("silverStrongCritChance")] 		public CFloat SilverStrongCritChance { get; set;}

		[RED("silverStrongCritDmg")] 		public CFloat SilverStrongCritDmg { get; set;}

		[RED("silverStrongDPS")] 		public CFloat SilverStrongDPS { get; set;}

		[RED("crossbowCritChance")] 		public CFloat CrossbowCritChance { get; set;}

		[RED("crossbowSteelDmg")] 		public CFloat CrossbowSteelDmg { get; set;}

		[RED("crossbowSteelDmgType")] 		public CName CrossbowSteelDmgType { get; set;}

		[RED("crossbowSilverDmg")] 		public CFloat CrossbowSilverDmg { get; set;}

		public SPlayerOffenseStats(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SPlayerOffenseStats(cr2w);

	}
}