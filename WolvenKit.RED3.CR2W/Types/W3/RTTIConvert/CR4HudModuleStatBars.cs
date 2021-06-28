using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleStatBars : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetVitalitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitalitySFF { get; set;}

		[Ordinal(2)] [RED("m_fxSetStaminaSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetStaminaSFF { get; set;}

		[Ordinal(3)] [RED("m_fxSetToxicitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetToxicitySFF { get; set;}

		[Ordinal(4)] [RED("m_fxSetExperienceSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetExperienceSFF { get; set;}

		[Ordinal(5)] [RED("m_fxSetLevelUpVisibleSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetLevelUpVisibleSFF { get; set;}

		[Ordinal(6)] [RED("m_fxStartHeavyAttackIndicatorAnimationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxStartHeavyAttackIndicatorAnimationSFF { get; set;}

		[Ordinal(7)] [RED("m_fxStopHeavyAttackIndicatorAnimationSFF")] 		public CHandle<CScriptedFlashFunction> M_fxStopHeavyAttackIndicatorAnimationSFF { get; set;}

		[Ordinal(8)] [RED("m_fxShowStatbarsGlowSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowStatbarsGlowSFF { get; set;}

		[Ordinal(9)] [RED("m_fxHideStatbarsGlowSFF")] 		public CHandle<CScriptedFlashFunction> M_fxHideStatbarsGlowSFF { get; set;}

		[Ordinal(10)] [RED("m_fxShowStaminaIndicatorSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowStaminaIndicatorSFF { get; set;}

		[Ordinal(11)] [RED("_vitality")] 		public CFloat _vitality { get; set;}

		[Ordinal(12)] [RED("_stamina")] 		public CFloat _stamina { get; set;}

		[Ordinal(13)] [RED("_toxicity")] 		public CFloat _toxicity { get; set;}

		[Ordinal(14)] [RED("_experience")] 		public CInt32 _experience { get; set;}

		[Ordinal(15)] [RED("_maxVitality")] 		public CFloat _maxVitality { get; set;}

		[Ordinal(16)] [RED("_maxStamina")] 		public CFloat _maxStamina { get; set;}

		[Ordinal(17)] [RED("_maxToxicity")] 		public CFloat _maxToxicity { get; set;}

		[Ordinal(18)] [RED("_maxExperience")] 		public CInt32 _maxExperience { get; set;}

		[Ordinal(19)] [RED("_showLevelUp")] 		public CBool _showLevelUp { get; set;}

		[Ordinal(20)] [RED("_currentLevel")] 		public CInt32 _currentLevel { get; set;}

		[Ordinal(21)] [RED("_heavyAttackIndicatorSpeed")] 		public CInt32 _heavyAttackIndicatorSpeed { get; set;}

		[Ordinal(22)] [RED("_heavyAttackGlowDurration")] 		public CInt32 _heavyAttackGlowDurration { get; set;}

		[Ordinal(23)] [RED("_heavyAttackSecondLevelIndicatorSpeed")] 		public CInt32 _heavyAttackSecondLevelIndicatorSpeed { get; set;}

		[Ordinal(24)] [RED("_heavyAttackSecondLevelGlowDurration")] 		public CInt32 _heavyAttackSecondLevelGlowDurration { get; set;}

		[Ordinal(25)] [RED("_duringHeavyAttackAnimation")] 		public CBool _duringHeavyAttackAnimation { get; set;}

		[Ordinal(26)] [RED("_bHeavyAttackFirstLevel")] 		public CBool _bHeavyAttackFirstLevel { get; set;}

		public CR4HudModuleStatBars(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}