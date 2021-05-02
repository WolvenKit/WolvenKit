using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPlayerOffenseStats : CVariable
	{
		[Ordinal(1)] [RED("steelFastDmg")] 		public CFloat SteelFastDmg { get; set;}

		[Ordinal(2)] [RED("steelFastCritChance")] 		public CFloat SteelFastCritChance { get; set;}

		[Ordinal(3)] [RED("steelFastCritDmg")] 		public CFloat SteelFastCritDmg { get; set;}

		[Ordinal(4)] [RED("steelFastDPS")] 		public CFloat SteelFastDPS { get; set;}

		[Ordinal(5)] [RED("steelStrongDmg")] 		public CFloat SteelStrongDmg { get; set;}

		[Ordinal(6)] [RED("steelStrongCritChance")] 		public CFloat SteelStrongCritChance { get; set;}

		[Ordinal(7)] [RED("steelStrongCritDmg")] 		public CFloat SteelStrongCritDmg { get; set;}

		[Ordinal(8)] [RED("steelStrongDPS")] 		public CFloat SteelStrongDPS { get; set;}

		[Ordinal(9)] [RED("silverFastDmg")] 		public CFloat SilverFastDmg { get; set;}

		[Ordinal(10)] [RED("silverFastCritChance")] 		public CFloat SilverFastCritChance { get; set;}

		[Ordinal(11)] [RED("silverFastCritDmg")] 		public CFloat SilverFastCritDmg { get; set;}

		[Ordinal(12)] [RED("silverFastDPS")] 		public CFloat SilverFastDPS { get; set;}

		[Ordinal(13)] [RED("silverStrongDmg")] 		public CFloat SilverStrongDmg { get; set;}

		[Ordinal(14)] [RED("silverStrongCritChance")] 		public CFloat SilverStrongCritChance { get; set;}

		[Ordinal(15)] [RED("silverStrongCritDmg")] 		public CFloat SilverStrongCritDmg { get; set;}

		[Ordinal(16)] [RED("silverStrongDPS")] 		public CFloat SilverStrongDPS { get; set;}

		[Ordinal(17)] [RED("crossbowCritChance")] 		public CFloat CrossbowCritChance { get; set;}

		[Ordinal(18)] [RED("crossbowSteelDmg")] 		public CFloat CrossbowSteelDmg { get; set;}

		[Ordinal(19)] [RED("crossbowSteelDmgType")] 		public CName CrossbowSteelDmgType { get; set;}

		[Ordinal(20)] [RED("crossbowSilverDmg")] 		public CFloat CrossbowSilverDmg { get; set;}

		public SPlayerOffenseStats(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}