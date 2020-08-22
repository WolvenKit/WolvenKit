using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleStatBars : CR4HudModuleBase
	{
		[RED("m_fxSetVitalitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitalitySFF { get; set;}

		[RED("m_fxSetStaminaSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetStaminaSFF { get; set;}

		[RED("m_fxSetToxicitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetToxicitySFF { get; set;}

		[RED("m_fxSetExperienceSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetExperienceSFF { get; set;}

		[RED("m_fxSetLevelUpVisibleSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetLevelUpVisibleSFF { get; set;}

		[RED("m_fxStartHeavyAttackIndicatorAnimationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxStartHeavyAttackIndicatorAnimationSFF { get; set;}

		[RED("m_fxStopHeavyAttackIndicatorAnimationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxStopHeavyAttackIndicatorAnimationSFF { get; set;}

		[RED("m_fxShowStatbarsGlowSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowStatbarsGlowSFF { get; set;}

		[RED("m_fxHideStatbarsGlowSFF")] 		public CHandle<CScriptedFlashFunction> M_fxHideStatbarsGlowSFF { get; set;}

		[RED("m_fxShowStaminaIndicatorSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowStaminaIndicatorSFF { get; set;}

		[RED("_vitality")] 		public CFloat _vitality { get; set;}

		[RED("_stamina")] 		public CFloat _stamina { get; set;}

		[RED("_toxicity")] 		public CFloat _toxicity { get; set;}

		[RED("_experience")] 		public CInt32 _experience { get; set;}

		[RED("_maxVitality")] 		public CFloat _maxVitality { get; set;}

		[RED("_maxStamina")] 		public CFloat _maxStamina { get; set;}

		[RED("_maxToxicity")] 		public CFloat _maxToxicity { get; set;}

		[RED("_maxExperience")] 		public CInt32 _maxExperience { get; set;}

		[RED("_showLevelUp")] 		public CBool _showLevelUp { get; set;}

		[RED("_currentLevel")] 		public CInt32 _currentLevel { get; set;}

		[RED("_heavyAttackIndicatorSpeed")] 		public CInt32 _heavyAttackIndicatorSpeed { get; set;}

		[RED("_heavyAttackGlowDurration")] 		public CInt32 _heavyAttackGlowDurration { get; set;}

		[RED("_heavyAttackSecondLevelIndicatorSpeed")] 		public CInt32 _heavyAttackSecondLevelIndicatorSpeed { get; set;}

		[RED("_heavyAttackSecondLevelGlowDurration")] 		public CInt32 _heavyAttackSecondLevelGlowDurration { get; set;}

		[RED("_duringHeavyAttackAnimation")] 		public CBool _duringHeavyAttackAnimation { get; set;}

		[RED("_bHeavyAttackFirstLevel")] 		public CBool _bHeavyAttackFirstLevel { get; set;}

		public CR4HudModuleStatBars(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleStatBars(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}