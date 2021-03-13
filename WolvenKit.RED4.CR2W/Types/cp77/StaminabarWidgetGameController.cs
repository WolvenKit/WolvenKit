using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaminabarWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("staminaControllerRef")] public inkWidgetReference StaminaControllerRef { get; set; }
		[Ordinal(10)] [RED("staminaPercTextPath")] public inkTextWidgetReference StaminaPercTextPath { get; set; }
		[Ordinal(11)] [RED("staminaStatusTextPath")] public inkTextWidgetReference StaminaStatusTextPath { get; set; }
		[Ordinal(12)] [RED("bbPSceneTierEventId")] public CUInt32 BbPSceneTierEventId { get; set; }
		[Ordinal(13)] [RED("bbPStaminaPSMEventId")] public CUInt32 BbPStaminaPSMEventId { get; set; }
		[Ordinal(14)] [RED("staminaController")] public wCHandle<NameplateBarLogicController> StaminaController { get; set; }
		[Ordinal(15)] [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(16)] [RED("animLongFade")] public CHandle<inkanimDefinition> AnimLongFade { get; set; }
		[Ordinal(17)] [RED("animHideStaminaProxy")] public CHandle<inkanimProxy> AnimHideStaminaProxy { get; set; }
		[Ordinal(18)] [RED("currentStamina")] public CFloat CurrentStamina { get; set; }
		[Ordinal(19)] [RED("sceneTier")] public CEnum<GameplayTier> SceneTier { get; set; }
		[Ordinal(20)] [RED("staminaState")] public CEnum<gamePSMStamina> StaminaState { get; set; }
		[Ordinal(21)] [RED("staminaPoolListener")] public CHandle<StaminaPoolListener> StaminaPoolListener { get; set; }

		public StaminabarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
