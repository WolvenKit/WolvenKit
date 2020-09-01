using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPlayerOffenseStats : CVariable
	{
		[Ordinal(0)] [RED("("steelFastDmg")] 		public CFloat SteelFastDmg { get; set;}

		[Ordinal(0)] [RED("("steelFastCritChance")] 		public CFloat SteelFastCritChance { get; set;}

		[Ordinal(0)] [RED("("steelFastCritDmg")] 		public CFloat SteelFastCritDmg { get; set;}

		[Ordinal(0)] [RED("("steelFastDPS")] 		public CFloat SteelFastDPS { get; set;}

		[Ordinal(0)] [RED("("steelStrongDmg")] 		public CFloat SteelStrongDmg { get; set;}

		[Ordinal(0)] [RED("("steelStrongCritChance")] 		public CFloat SteelStrongCritChance { get; set;}

		[Ordinal(0)] [RED("("steelStrongCritDmg")] 		public CFloat SteelStrongCritDmg { get; set;}

		[Ordinal(0)] [RED("("steelStrongDPS")] 		public CFloat SteelStrongDPS { get; set;}

		[Ordinal(0)] [RED("("silverFastDmg")] 		public CFloat SilverFastDmg { get; set;}

		[Ordinal(0)] [RED("("silverFastCritChance")] 		public CFloat SilverFastCritChance { get; set;}

		[Ordinal(0)] [RED("("silverFastCritDmg")] 		public CFloat SilverFastCritDmg { get; set;}

		[Ordinal(0)] [RED("("silverFastDPS")] 		public CFloat SilverFastDPS { get; set;}

		[Ordinal(0)] [RED("("silverStrongDmg")] 		public CFloat SilverStrongDmg { get; set;}

		[Ordinal(0)] [RED("("silverStrongCritChance")] 		public CFloat SilverStrongCritChance { get; set;}

		[Ordinal(0)] [RED("("silverStrongCritDmg")] 		public CFloat SilverStrongCritDmg { get; set;}

		[Ordinal(0)] [RED("("silverStrongDPS")] 		public CFloat SilverStrongDPS { get; set;}

		[Ordinal(0)] [RED("("crossbowCritChance")] 		public CFloat CrossbowCritChance { get; set;}

		[Ordinal(0)] [RED("("crossbowSteelDmg")] 		public CFloat CrossbowSteelDmg { get; set;}

		[Ordinal(0)] [RED("("crossbowSteelDmgType")] 		public CName CrossbowSteelDmgType { get; set;}

		[Ordinal(0)] [RED("("crossbowSilverDmg")] 		public CFloat CrossbowSilverDmg { get; set;}

		public SPlayerOffenseStats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPlayerOffenseStats(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}