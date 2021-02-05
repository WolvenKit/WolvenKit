using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StaminabarWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("staminaControllerRef")] public inkWidgetReference StaminaControllerRef { get; set; }
		[Ordinal(8)]  [RED("staminaPercTextPath")] public inkTextWidgetReference StaminaPercTextPath { get; set; }
		[Ordinal(9)]  [RED("staminaStatusTextPath")] public inkTextWidgetReference StaminaStatusTextPath { get; set; }
		[Ordinal(10)]  [RED("bbPSceneTierEventId")] public CUInt32 BbPSceneTierEventId { get; set; }
		[Ordinal(11)]  [RED("bbPStaminaPSMEventId")] public CUInt32 BbPStaminaPSMEventId { get; set; }
		[Ordinal(12)]  [RED("staminaController")] public wCHandle<NameplateBarLogicController> StaminaController { get; set; }
		[Ordinal(13)]  [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(14)]  [RED("animLongFade")] public CHandle<inkanimDefinition> AnimLongFade { get; set; }
		[Ordinal(15)]  [RED("animHideStaminaProxy")] public CHandle<inkanimProxy> AnimHideStaminaProxy { get; set; }
		[Ordinal(16)]  [RED("currentStamina")] public CFloat CurrentStamina { get; set; }
		[Ordinal(17)]  [RED("sceneTier")] public CEnum<GameplayTier> SceneTier { get; set; }
		[Ordinal(18)]  [RED("staminaState")] public CEnum<gamePSMStamina> StaminaState { get; set; }
		[Ordinal(19)]  [RED("staminaPoolListener")] public CHandle<StaminaPoolListener> StaminaPoolListener { get; set; }

		public StaminabarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
