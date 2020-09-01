using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W2BalanceCalc : CObject
	{
		[Ordinal(0)] [RED("("abilities", 2,0)] 		public CArray<CName> Abilities { get; set;}

		[Ordinal(0)] [RED("("petards", 2,0)] 		public CArray<SItemUniqueId> Petards { get; set;}

		[Ordinal(0)] [RED("("cost")] 		public CFloat Cost { get; set;}

		[Ordinal(0)] [RED("("statVitality")] 		public CFloat StatVitality { get; set;}

		[Ordinal(0)] [RED("("statCurrentVitality")] 		public CFloat StatCurrentVitality { get; set;}

		[Ordinal(0)] [RED("("statEssence")] 		public CFloat StatEssence { get; set;}

		[Ordinal(0)] [RED("("statCurrentEssence")] 		public CFloat StatCurrentEssence { get; set;}

		[Ordinal(0)] [RED("("statStamina")] 		public CFloat StatStamina { get; set;}

		[Ordinal(0)] [RED("("statCurrentStamina")] 		public CFloat StatCurrentStamina { get; set;}

		[Ordinal(0)] [RED("("statFocus")] 		public CFloat StatFocus { get; set;}

		[Ordinal(0)] [RED("("statToxicity")] 		public CFloat StatToxicity { get; set;}

		[Ordinal(0)] [RED("("statMorale")] 		public CFloat StatMorale { get; set;}

		[Ordinal(0)] [RED("("statSickness")] 		public CFloat StatSickness { get; set;}

		[Ordinal(0)] [RED("("statParryChance")] 		public CFloat StatParryChance { get; set;}

		[Ordinal(0)] [RED("("statDodgeChance")] 		public CFloat StatDodgeChance { get; set;}

		[Ordinal(0)] [RED("("statVitalityRegen")] 		public CFloat StatVitalityRegen { get; set;}

		[Ordinal(0)] [RED("("statEssenceRegen")] 		public CFloat StatEssenceRegen { get; set;}

		[Ordinal(0)] [RED("("statStaminaRegen")] 		public CFloat StatStaminaRegen { get; set;}

		[Ordinal(0)] [RED("("statFocusRegen")] 		public CFloat StatFocusRegen { get; set;}

		[Ordinal(0)] [RED("("statToxicityRegen")] 		public CFloat StatToxicityRegen { get; set;}

		[Ordinal(0)] [RED("("statMoraleRegen")] 		public CFloat StatMoraleRegen { get; set;}

		[Ordinal(0)] [RED("("statSicknessRegen")] 		public CFloat StatSicknessRegen { get; set;}

		[Ordinal(0)] [RED("("statAttackPower")] 		public CFloat StatAttackPower { get; set;}

		[Ordinal(0)] [RED("("statSpellPower")] 		public CFloat StatSpellPower { get; set;}

		[Ordinal(0)] [RED("("statEffectDuration")] 		public CFloat StatEffectDuration { get; set;}

		[Ordinal(0)] [RED("("statVitalityDmg")] 		public CFloat StatVitalityDmg { get; set;}

		[Ordinal(0)] [RED("("statEssenceDmg")] 		public CFloat StatEssenceDmg { get; set;}

		[Ordinal(0)] [RED("("statSpellDmg")] 		public CFloat StatSpellDmg { get; set;}

		[Ordinal(0)] [RED("("statRange")] 		public CFloat StatRange { get; set;}

		[Ordinal(0)] [RED("("statRadius")] 		public CFloat StatRadius { get; set;}

		[Ordinal(0)] [RED("("statPhysicalRes")] 		public CFloat StatPhysicalRes { get; set;}

		[Ordinal(0)] [RED("("statFireRes")] 		public CFloat StatFireRes { get; set;}

		[Ordinal(0)] [RED("("statFrostRes")] 		public CFloat StatFrostRes { get; set;}

		[Ordinal(0)] [RED("("statShockRes")] 		public CFloat StatShockRes { get; set;}

		[Ordinal(0)] [RED("("statPoisonRes")] 		public CFloat StatPoisonRes { get; set;}

		[Ordinal(0)] [RED("("statBleedingRes")] 		public CFloat StatBleedingRes { get; set;}

		[Ordinal(0)] [RED("("statIncinerationRes")] 		public CFloat StatIncinerationRes { get; set;}

		[Ordinal(0)] [RED("("costVitality")] 		public CFloat CostVitality { get; set;}

		[Ordinal(0)] [RED("("costEssence")] 		public CFloat CostEssence { get; set;}

		[Ordinal(0)] [RED("("costStamina")] 		public CFloat CostStamina { get; set;}

		[Ordinal(0)] [RED("("costFocus")] 		public CFloat CostFocus { get; set;}

		[Ordinal(0)] [RED("("costToxicity")] 		public CFloat CostToxicity { get; set;}

		[Ordinal(0)] [RED("("costMorale")] 		public CFloat CostMorale { get; set;}

		[Ordinal(0)] [RED("("costDrunkenness")] 		public CFloat CostDrunkenness { get; set;}

		[Ordinal(0)] [RED("("costSickness")] 		public CFloat CostSickness { get; set;}

		[Ordinal(0)] [RED("("costParryChance")] 		public CFloat CostParryChance { get; set;}

		[Ordinal(0)] [RED("("costDodgeChance")] 		public CFloat CostDodgeChance { get; set;}

		[Ordinal(0)] [RED("("costVitalityRegen")] 		public CFloat CostVitalityRegen { get; set;}

		[Ordinal(0)] [RED("("costEssenceRegen")] 		public CFloat CostEssenceRegen { get; set;}

		[Ordinal(0)] [RED("("costStaminaRegen")] 		public CFloat CostStaminaRegen { get; set;}

		[Ordinal(0)] [RED("("costFocusRegen")] 		public CFloat CostFocusRegen { get; set;}

		[Ordinal(0)] [RED("("costToxicityRegen")] 		public CFloat CostToxicityRegen { get; set;}

		[Ordinal(0)] [RED("("costMoraleRegen")] 		public CFloat CostMoraleRegen { get; set;}

		[Ordinal(0)] [RED("("costDrunkennessRegen")] 		public CFloat CostDrunkennessRegen { get; set;}

		[Ordinal(0)] [RED("("costSicknessRegen")] 		public CFloat CostSicknessRegen { get; set;}

		[Ordinal(0)] [RED("("costAttackPower")] 		public CFloat CostAttackPower { get; set;}

		[Ordinal(0)] [RED("("costSpellPower")] 		public CFloat CostSpellPower { get; set;}

		[Ordinal(0)] [RED("("costEffectDuration")] 		public CFloat CostEffectDuration { get; set;}

		[Ordinal(0)] [RED("("costVitalityDmg")] 		public CFloat CostVitalityDmg { get; set;}

		[Ordinal(0)] [RED("("costEssenceDmg")] 		public CFloat CostEssenceDmg { get; set;}

		[Ordinal(0)] [RED("("costSpellDmg")] 		public CFloat CostSpellDmg { get; set;}

		[Ordinal(0)] [RED("("costRange")] 		public CFloat CostRange { get; set;}

		[Ordinal(0)] [RED("("costRadius")] 		public CFloat CostRadius { get; set;}

		[Ordinal(0)] [RED("("costPhysicalRes")] 		public CFloat CostPhysicalRes { get; set;}

		[Ordinal(0)] [RED("("costFireRes")] 		public CFloat CostFireRes { get; set;}

		[Ordinal(0)] [RED("("costFrostRes")] 		public CFloat CostFrostRes { get; set;}

		[Ordinal(0)] [RED("("costShockRes")] 		public CFloat CostShockRes { get; set;}

		[Ordinal(0)] [RED("("costPoisonRes")] 		public CFloat CostPoisonRes { get; set;}

		[Ordinal(0)] [RED("("costBleedingRes")] 		public CFloat CostBleedingRes { get; set;}

		[Ordinal(0)] [RED("("costIncinerationRes")] 		public CFloat CostIncinerationRes { get; set;}

		[Ordinal(0)] [RED("("costconstVitality")] 		public CFloat CostconstVitality { get; set;}

		[Ordinal(0)] [RED("("costconstEssence")] 		public CFloat CostconstEssence { get; set;}

		[Ordinal(0)] [RED("("costconstStamina")] 		public CFloat CostconstStamina { get; set;}

		[Ordinal(0)] [RED("("costconstFocus")] 		public CFloat CostconstFocus { get; set;}

		[Ordinal(0)] [RED("("costconstToxicity")] 		public CFloat CostconstToxicity { get; set;}

		[Ordinal(0)] [RED("("costconstMorale")] 		public CFloat CostconstMorale { get; set;}

		[Ordinal(0)] [RED("("costconstDrunkenness")] 		public CFloat CostconstDrunkenness { get; set;}

		[Ordinal(0)] [RED("("costconstSickness")] 		public CFloat CostconstSickness { get; set;}

		[Ordinal(0)] [RED("("costconstParryChance")] 		public CFloat CostconstParryChance { get; set;}

		[Ordinal(0)] [RED("("costconstDodgeChance")] 		public CFloat CostconstDodgeChance { get; set;}

		[Ordinal(0)] [RED("("costconstVitalityRegen")] 		public CFloat CostconstVitalityRegen { get; set;}

		[Ordinal(0)] [RED("("costconstEssenceRegen")] 		public CFloat CostconstEssenceRegen { get; set;}

		[Ordinal(0)] [RED("("costconstStaminaRegen")] 		public CFloat CostconstStaminaRegen { get; set;}

		[Ordinal(0)] [RED("("costconstFocusRegen")] 		public CFloat CostconstFocusRegen { get; set;}

		[Ordinal(0)] [RED("("costconstToxicityRegen")] 		public CFloat CostconstToxicityRegen { get; set;}

		[Ordinal(0)] [RED("("costconstMoraleRegen")] 		public CFloat CostconstMoraleRegen { get; set;}

		[Ordinal(0)] [RED("("costconstDrunkennessRegen")] 		public CFloat CostconstDrunkennessRegen { get; set;}

		[Ordinal(0)] [RED("("costconstSicknessRegen")] 		public CFloat CostconstSicknessRegen { get; set;}

		[Ordinal(0)] [RED("("costconstAttackPower")] 		public CFloat CostconstAttackPower { get; set;}

		[Ordinal(0)] [RED("("costconstSpellPower")] 		public CFloat CostconstSpellPower { get; set;}

		[Ordinal(0)] [RED("("costconstEffectDuration")] 		public CFloat CostconstEffectDuration { get; set;}

		[Ordinal(0)] [RED("("costconstVitalityDmg")] 		public CFloat CostconstVitalityDmg { get; set;}

		[Ordinal(0)] [RED("("costconstEssenceDmg")] 		public CFloat CostconstEssenceDmg { get; set;}

		[Ordinal(0)] [RED("("costconstSpellDmg")] 		public CFloat CostconstSpellDmg { get; set;}

		[Ordinal(0)] [RED("("costconstRange")] 		public CFloat CostconstRange { get; set;}

		[Ordinal(0)] [RED("("costconstRadius")] 		public CFloat CostconstRadius { get; set;}

		[Ordinal(0)] [RED("("costconstPhysicalRes")] 		public CFloat CostconstPhysicalRes { get; set;}

		[Ordinal(0)] [RED("("costconstFireRes")] 		public CFloat CostconstFireRes { get; set;}

		[Ordinal(0)] [RED("("costconstFrostRes")] 		public CFloat CostconstFrostRes { get; set;}

		[Ordinal(0)] [RED("("costconstShockRes")] 		public CFloat CostconstShockRes { get; set;}

		[Ordinal(0)] [RED("("costconstPoisonRes")] 		public CFloat CostconstPoisonRes { get; set;}

		[Ordinal(0)] [RED("("costconstBleedingRes")] 		public CFloat CostconstBleedingRes { get; set;}

		[Ordinal(0)] [RED("("costconstIncinerationRes")] 		public CFloat CostconstIncinerationRes { get; set;}

		public W2BalanceCalc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W2BalanceCalc(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}