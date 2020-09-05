using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W2BalanceCalc : CObject
	{
		[Ordinal(1)] [RED("abilities", 2,0)] 		public CArray<CName> Abilities { get; set;}

		[Ordinal(2)] [RED("petards", 2,0)] 		public CArray<SItemUniqueId> Petards { get; set;}

		[Ordinal(3)] [RED("cost")] 		public CFloat Cost { get; set;}

		[Ordinal(4)] [RED("statVitality")] 		public CFloat StatVitality { get; set;}

		[Ordinal(5)] [RED("statCurrentVitality")] 		public CFloat StatCurrentVitality { get; set;}

		[Ordinal(6)] [RED("statEssence")] 		public CFloat StatEssence { get; set;}

		[Ordinal(7)] [RED("statCurrentEssence")] 		public CFloat StatCurrentEssence { get; set;}

		[Ordinal(8)] [RED("statStamina")] 		public CFloat StatStamina { get; set;}

		[Ordinal(9)] [RED("statCurrentStamina")] 		public CFloat StatCurrentStamina { get; set;}

		[Ordinal(10)] [RED("statFocus")] 		public CFloat StatFocus { get; set;}

		[Ordinal(11)] [RED("statToxicity")] 		public CFloat StatToxicity { get; set;}

		[Ordinal(12)] [RED("statMorale")] 		public CFloat StatMorale { get; set;}

		[Ordinal(13)] [RED("statSickness")] 		public CFloat StatSickness { get; set;}

		[Ordinal(14)] [RED("statParryChance")] 		public CFloat StatParryChance { get; set;}

		[Ordinal(15)] [RED("statDodgeChance")] 		public CFloat StatDodgeChance { get; set;}

		[Ordinal(16)] [RED("statVitalityRegen")] 		public CFloat StatVitalityRegen { get; set;}

		[Ordinal(17)] [RED("statEssenceRegen")] 		public CFloat StatEssenceRegen { get; set;}

		[Ordinal(18)] [RED("statStaminaRegen")] 		public CFloat StatStaminaRegen { get; set;}

		[Ordinal(19)] [RED("statFocusRegen")] 		public CFloat StatFocusRegen { get; set;}

		[Ordinal(20)] [RED("statToxicityRegen")] 		public CFloat StatToxicityRegen { get; set;}

		[Ordinal(21)] [RED("statMoraleRegen")] 		public CFloat StatMoraleRegen { get; set;}

		[Ordinal(22)] [RED("statSicknessRegen")] 		public CFloat StatSicknessRegen { get; set;}

		[Ordinal(23)] [RED("statAttackPower")] 		public CFloat StatAttackPower { get; set;}

		[Ordinal(24)] [RED("statSpellPower")] 		public CFloat StatSpellPower { get; set;}

		[Ordinal(25)] [RED("statEffectDuration")] 		public CFloat StatEffectDuration { get; set;}

		[Ordinal(26)] [RED("statVitalityDmg")] 		public CFloat StatVitalityDmg { get; set;}

		[Ordinal(27)] [RED("statEssenceDmg")] 		public CFloat StatEssenceDmg { get; set;}

		[Ordinal(28)] [RED("statSpellDmg")] 		public CFloat StatSpellDmg { get; set;}

		[Ordinal(29)] [RED("statRange")] 		public CFloat StatRange { get; set;}

		[Ordinal(30)] [RED("statRadius")] 		public CFloat StatRadius { get; set;}

		[Ordinal(31)] [RED("statPhysicalRes")] 		public CFloat StatPhysicalRes { get; set;}

		[Ordinal(32)] [RED("statFireRes")] 		public CFloat StatFireRes { get; set;}

		[Ordinal(33)] [RED("statFrostRes")] 		public CFloat StatFrostRes { get; set;}

		[Ordinal(34)] [RED("statShockRes")] 		public CFloat StatShockRes { get; set;}

		[Ordinal(35)] [RED("statPoisonRes")] 		public CFloat StatPoisonRes { get; set;}

		[Ordinal(36)] [RED("statBleedingRes")] 		public CFloat StatBleedingRes { get; set;}

		[Ordinal(37)] [RED("statIncinerationRes")] 		public CFloat StatIncinerationRes { get; set;}

		[Ordinal(38)] [RED("costVitality")] 		public CFloat CostVitality { get; set;}

		[Ordinal(39)] [RED("costEssence")] 		public CFloat CostEssence { get; set;}

		[Ordinal(40)] [RED("costStamina")] 		public CFloat CostStamina { get; set;}

		[Ordinal(41)] [RED("costFocus")] 		public CFloat CostFocus { get; set;}

		[Ordinal(42)] [RED("costToxicity")] 		public CFloat CostToxicity { get; set;}

		[Ordinal(43)] [RED("costMorale")] 		public CFloat CostMorale { get; set;}

		[Ordinal(44)] [RED("costDrunkenness")] 		public CFloat CostDrunkenness { get; set;}

		[Ordinal(45)] [RED("costSickness")] 		public CFloat CostSickness { get; set;}

		[Ordinal(46)] [RED("costParryChance")] 		public CFloat CostParryChance { get; set;}

		[Ordinal(47)] [RED("costDodgeChance")] 		public CFloat CostDodgeChance { get; set;}

		[Ordinal(48)] [RED("costVitalityRegen")] 		public CFloat CostVitalityRegen { get; set;}

		[Ordinal(49)] [RED("costEssenceRegen")] 		public CFloat CostEssenceRegen { get; set;}

		[Ordinal(50)] [RED("costStaminaRegen")] 		public CFloat CostStaminaRegen { get; set;}

		[Ordinal(51)] [RED("costFocusRegen")] 		public CFloat CostFocusRegen { get; set;}

		[Ordinal(52)] [RED("costToxicityRegen")] 		public CFloat CostToxicityRegen { get; set;}

		[Ordinal(53)] [RED("costMoraleRegen")] 		public CFloat CostMoraleRegen { get; set;}

		[Ordinal(54)] [RED("costDrunkennessRegen")] 		public CFloat CostDrunkennessRegen { get; set;}

		[Ordinal(55)] [RED("costSicknessRegen")] 		public CFloat CostSicknessRegen { get; set;}

		[Ordinal(56)] [RED("costAttackPower")] 		public CFloat CostAttackPower { get; set;}

		[Ordinal(57)] [RED("costSpellPower")] 		public CFloat CostSpellPower { get; set;}

		[Ordinal(58)] [RED("costEffectDuration")] 		public CFloat CostEffectDuration { get; set;}

		[Ordinal(59)] [RED("costVitalityDmg")] 		public CFloat CostVitalityDmg { get; set;}

		[Ordinal(60)] [RED("costEssenceDmg")] 		public CFloat CostEssenceDmg { get; set;}

		[Ordinal(61)] [RED("costSpellDmg")] 		public CFloat CostSpellDmg { get; set;}

		[Ordinal(62)] [RED("costRange")] 		public CFloat CostRange { get; set;}

		[Ordinal(63)] [RED("costRadius")] 		public CFloat CostRadius { get; set;}

		[Ordinal(64)] [RED("costPhysicalRes")] 		public CFloat CostPhysicalRes { get; set;}

		[Ordinal(65)] [RED("costFireRes")] 		public CFloat CostFireRes { get; set;}

		[Ordinal(66)] [RED("costFrostRes")] 		public CFloat CostFrostRes { get; set;}

		[Ordinal(67)] [RED("costShockRes")] 		public CFloat CostShockRes { get; set;}

		[Ordinal(68)] [RED("costPoisonRes")] 		public CFloat CostPoisonRes { get; set;}

		[Ordinal(69)] [RED("costBleedingRes")] 		public CFloat CostBleedingRes { get; set;}

		[Ordinal(70)] [RED("costIncinerationRes")] 		public CFloat CostIncinerationRes { get; set;}

		[Ordinal(71)] [RED("costconstVitality")] 		public CFloat CostconstVitality { get; set;}

		[Ordinal(72)] [RED("costconstEssence")] 		public CFloat CostconstEssence { get; set;}

		[Ordinal(73)] [RED("costconstStamina")] 		public CFloat CostconstStamina { get; set;}

		[Ordinal(74)] [RED("costconstFocus")] 		public CFloat CostconstFocus { get; set;}

		[Ordinal(75)] [RED("costconstToxicity")] 		public CFloat CostconstToxicity { get; set;}

		[Ordinal(76)] [RED("costconstMorale")] 		public CFloat CostconstMorale { get; set;}

		[Ordinal(77)] [RED("costconstDrunkenness")] 		public CFloat CostconstDrunkenness { get; set;}

		[Ordinal(78)] [RED("costconstSickness")] 		public CFloat CostconstSickness { get; set;}

		[Ordinal(79)] [RED("costconstParryChance")] 		public CFloat CostconstParryChance { get; set;}

		[Ordinal(80)] [RED("costconstDodgeChance")] 		public CFloat CostconstDodgeChance { get; set;}

		[Ordinal(81)] [RED("costconstVitalityRegen")] 		public CFloat CostconstVitalityRegen { get; set;}

		[Ordinal(82)] [RED("costconstEssenceRegen")] 		public CFloat CostconstEssenceRegen { get; set;}

		[Ordinal(83)] [RED("costconstStaminaRegen")] 		public CFloat CostconstStaminaRegen { get; set;}

		[Ordinal(84)] [RED("costconstFocusRegen")] 		public CFloat CostconstFocusRegen { get; set;}

		[Ordinal(85)] [RED("costconstToxicityRegen")] 		public CFloat CostconstToxicityRegen { get; set;}

		[Ordinal(86)] [RED("costconstMoraleRegen")] 		public CFloat CostconstMoraleRegen { get; set;}

		[Ordinal(87)] [RED("costconstDrunkennessRegen")] 		public CFloat CostconstDrunkennessRegen { get; set;}

		[Ordinal(88)] [RED("costconstSicknessRegen")] 		public CFloat CostconstSicknessRegen { get; set;}

		[Ordinal(89)] [RED("costconstAttackPower")] 		public CFloat CostconstAttackPower { get; set;}

		[Ordinal(90)] [RED("costconstSpellPower")] 		public CFloat CostconstSpellPower { get; set;}

		[Ordinal(91)] [RED("costconstEffectDuration")] 		public CFloat CostconstEffectDuration { get; set;}

		[Ordinal(92)] [RED("costconstVitalityDmg")] 		public CFloat CostconstVitalityDmg { get; set;}

		[Ordinal(93)] [RED("costconstEssenceDmg")] 		public CFloat CostconstEssenceDmg { get; set;}

		[Ordinal(94)] [RED("costconstSpellDmg")] 		public CFloat CostconstSpellDmg { get; set;}

		[Ordinal(95)] [RED("costconstRange")] 		public CFloat CostconstRange { get; set;}

		[Ordinal(96)] [RED("costconstRadius")] 		public CFloat CostconstRadius { get; set;}

		[Ordinal(97)] [RED("costconstPhysicalRes")] 		public CFloat CostconstPhysicalRes { get; set;}

		[Ordinal(98)] [RED("costconstFireRes")] 		public CFloat CostconstFireRes { get; set;}

		[Ordinal(99)] [RED("costconstFrostRes")] 		public CFloat CostconstFrostRes { get; set;}

		[Ordinal(100)] [RED("costconstShockRes")] 		public CFloat CostconstShockRes { get; set;}

		[Ordinal(101)] [RED("costconstPoisonRes")] 		public CFloat CostconstPoisonRes { get; set;}

		[Ordinal(102)] [RED("costconstBleedingRes")] 		public CFloat CostconstBleedingRes { get; set;}

		[Ordinal(103)] [RED("costconstIncinerationRes")] 		public CFloat CostconstIncinerationRes { get; set;}

		public W2BalanceCalc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W2BalanceCalc(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}