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
		[RED("abilities", 2,0)] 		public CArray<CName> Abilities { get; set;}

		[RED("petards", 2,0)] 		public CArray<SItemUniqueId> Petards { get; set;}

		[RED("cost")] 		public CFloat Cost { get; set;}

		[RED("statVitality")] 		public CFloat StatVitality { get; set;}

		[RED("statCurrentVitality")] 		public CFloat StatCurrentVitality { get; set;}

		[RED("statEssence")] 		public CFloat StatEssence { get; set;}

		[RED("statCurrentEssence")] 		public CFloat StatCurrentEssence { get; set;}

		[RED("statStamina")] 		public CFloat StatStamina { get; set;}

		[RED("statCurrentStamina")] 		public CFloat StatCurrentStamina { get; set;}

		[RED("statFocus")] 		public CFloat StatFocus { get; set;}

		[RED("statToxicity")] 		public CFloat StatToxicity { get; set;}

		[RED("statMorale")] 		public CFloat StatMorale { get; set;}

		[RED("statSickness")] 		public CFloat StatSickness { get; set;}

		[RED("statParryChance")] 		public CFloat StatParryChance { get; set;}

		[RED("statDodgeChance")] 		public CFloat StatDodgeChance { get; set;}

		[RED("statVitalityRegen")] 		public CFloat StatVitalityRegen { get; set;}

		[RED("statEssenceRegen")] 		public CFloat StatEssenceRegen { get; set;}

		[RED("statStaminaRegen")] 		public CFloat StatStaminaRegen { get; set;}

		[RED("statFocusRegen")] 		public CFloat StatFocusRegen { get; set;}

		[RED("statToxicityRegen")] 		public CFloat StatToxicityRegen { get; set;}

		[RED("statMoraleRegen")] 		public CFloat StatMoraleRegen { get; set;}

		[RED("statSicknessRegen")] 		public CFloat StatSicknessRegen { get; set;}

		[RED("statAttackPower")] 		public CFloat StatAttackPower { get; set;}

		[RED("statSpellPower")] 		public CFloat StatSpellPower { get; set;}

		[RED("statEffectDuration")] 		public CFloat StatEffectDuration { get; set;}

		[RED("statVitalityDmg")] 		public CFloat StatVitalityDmg { get; set;}

		[RED("statEssenceDmg")] 		public CFloat StatEssenceDmg { get; set;}

		[RED("statSpellDmg")] 		public CFloat StatSpellDmg { get; set;}

		[RED("statRange")] 		public CFloat StatRange { get; set;}

		[RED("statRadius")] 		public CFloat StatRadius { get; set;}

		[RED("statPhysicalRes")] 		public CFloat StatPhysicalRes { get; set;}

		[RED("statFireRes")] 		public CFloat StatFireRes { get; set;}

		[RED("statFrostRes")] 		public CFloat StatFrostRes { get; set;}

		[RED("statShockRes")] 		public CFloat StatShockRes { get; set;}

		[RED("statPoisonRes")] 		public CFloat StatPoisonRes { get; set;}

		[RED("statBleedingRes")] 		public CFloat StatBleedingRes { get; set;}

		[RED("statIncinerationRes")] 		public CFloat StatIncinerationRes { get; set;}

		[RED("costVitality")] 		public CFloat CostVitality { get; set;}

		[RED("costEssence")] 		public CFloat CostEssence { get; set;}

		[RED("costStamina")] 		public CFloat CostStamina { get; set;}

		[RED("costFocus")] 		public CFloat CostFocus { get; set;}

		[RED("costToxicity")] 		public CFloat CostToxicity { get; set;}

		[RED("costMorale")] 		public CFloat CostMorale { get; set;}

		[RED("costDrunkenness")] 		public CFloat CostDrunkenness { get; set;}

		[RED("costSickness")] 		public CFloat CostSickness { get; set;}

		[RED("costParryChance")] 		public CFloat CostParryChance { get; set;}

		[RED("costDodgeChance")] 		public CFloat CostDodgeChance { get; set;}

		[RED("costVitalityRegen")] 		public CFloat CostVitalityRegen { get; set;}

		[RED("costEssenceRegen")] 		public CFloat CostEssenceRegen { get; set;}

		[RED("costStaminaRegen")] 		public CFloat CostStaminaRegen { get; set;}

		[RED("costFocusRegen")] 		public CFloat CostFocusRegen { get; set;}

		[RED("costToxicityRegen")] 		public CFloat CostToxicityRegen { get; set;}

		[RED("costMoraleRegen")] 		public CFloat CostMoraleRegen { get; set;}

		[RED("costDrunkennessRegen")] 		public CFloat CostDrunkennessRegen { get; set;}

		[RED("costSicknessRegen")] 		public CFloat CostSicknessRegen { get; set;}

		[RED("costAttackPower")] 		public CFloat CostAttackPower { get; set;}

		[RED("costSpellPower")] 		public CFloat CostSpellPower { get; set;}

		[RED("costEffectDuration")] 		public CFloat CostEffectDuration { get; set;}

		[RED("costVitalityDmg")] 		public CFloat CostVitalityDmg { get; set;}

		[RED("costEssenceDmg")] 		public CFloat CostEssenceDmg { get; set;}

		[RED("costSpellDmg")] 		public CFloat CostSpellDmg { get; set;}

		[RED("costRange")] 		public CFloat CostRange { get; set;}

		[RED("costRadius")] 		public CFloat CostRadius { get; set;}

		[RED("costPhysicalRes")] 		public CFloat CostPhysicalRes { get; set;}

		[RED("costFireRes")] 		public CFloat CostFireRes { get; set;}

		[RED("costFrostRes")] 		public CFloat CostFrostRes { get; set;}

		[RED("costShockRes")] 		public CFloat CostShockRes { get; set;}

		[RED("costPoisonRes")] 		public CFloat CostPoisonRes { get; set;}

		[RED("costBleedingRes")] 		public CFloat CostBleedingRes { get; set;}

		[RED("costIncinerationRes")] 		public CFloat CostIncinerationRes { get; set;}

		[RED("costconstVitality")] 		public CFloat CostconstVitality { get; set;}

		[RED("costconstEssence")] 		public CFloat CostconstEssence { get; set;}

		[RED("costconstStamina")] 		public CFloat CostconstStamina { get; set;}

		[RED("costconstFocus")] 		public CFloat CostconstFocus { get; set;}

		[RED("costconstToxicity")] 		public CFloat CostconstToxicity { get; set;}

		[RED("costconstMorale")] 		public CFloat CostconstMorale { get; set;}

		[RED("costconstDrunkenness")] 		public CFloat CostconstDrunkenness { get; set;}

		[RED("costconstSickness")] 		public CFloat CostconstSickness { get; set;}

		[RED("costconstParryChance")] 		public CFloat CostconstParryChance { get; set;}

		[RED("costconstDodgeChance")] 		public CFloat CostconstDodgeChance { get; set;}

		[RED("costconstVitalityRegen")] 		public CFloat CostconstVitalityRegen { get; set;}

		[RED("costconstEssenceRegen")] 		public CFloat CostconstEssenceRegen { get; set;}

		[RED("costconstStaminaRegen")] 		public CFloat CostconstStaminaRegen { get; set;}

		[RED("costconstFocusRegen")] 		public CFloat CostconstFocusRegen { get; set;}

		[RED("costconstToxicityRegen")] 		public CFloat CostconstToxicityRegen { get; set;}

		[RED("costconstMoraleRegen")] 		public CFloat CostconstMoraleRegen { get; set;}

		[RED("costconstDrunkennessRegen")] 		public CFloat CostconstDrunkennessRegen { get; set;}

		[RED("costconstSicknessRegen")] 		public CFloat CostconstSicknessRegen { get; set;}

		[RED("costconstAttackPower")] 		public CFloat CostconstAttackPower { get; set;}

		[RED("costconstSpellPower")] 		public CFloat CostconstSpellPower { get; set;}

		[RED("costconstEffectDuration")] 		public CFloat CostconstEffectDuration { get; set;}

		[RED("costconstVitalityDmg")] 		public CFloat CostconstVitalityDmg { get; set;}

		[RED("costconstEssenceDmg")] 		public CFloat CostconstEssenceDmg { get; set;}

		[RED("costconstSpellDmg")] 		public CFloat CostconstSpellDmg { get; set;}

		[RED("costconstRange")] 		public CFloat CostconstRange { get; set;}

		[RED("costconstRadius")] 		public CFloat CostconstRadius { get; set;}

		[RED("costconstPhysicalRes")] 		public CFloat CostconstPhysicalRes { get; set;}

		[RED("costconstFireRes")] 		public CFloat CostconstFireRes { get; set;}

		[RED("costconstFrostRes")] 		public CFloat CostconstFrostRes { get; set;}

		[RED("costconstShockRes")] 		public CFloat CostconstShockRes { get; set;}

		[RED("costconstPoisonRes")] 		public CFloat CostconstPoisonRes { get; set;}

		[RED("costconstBleedingRes")] 		public CFloat CostconstBleedingRes { get; set;}

		[RED("costconstIncinerationRes")] 		public CFloat CostconstIncinerationRes { get; set;}

		public W2BalanceCalc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W2BalanceCalc(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}