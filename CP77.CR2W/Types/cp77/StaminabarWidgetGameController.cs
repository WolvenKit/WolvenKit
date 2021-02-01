using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StaminabarWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(1)]  [RED("animHideStaminaProxy")] public CHandle<inkanimProxy> AnimHideStaminaProxy { get; set; }
		[Ordinal(2)]  [RED("animLongFade")] public CHandle<inkanimDefinition> AnimLongFade { get; set; }
		[Ordinal(3)]  [RED("bbPSceneTierEventId")] public CUInt32 BbPSceneTierEventId { get; set; }
		[Ordinal(4)]  [RED("bbPStaminaPSMEventId")] public CUInt32 BbPStaminaPSMEventId { get; set; }
		[Ordinal(5)]  [RED("currentStamina")] public CFloat CurrentStamina { get; set; }
		[Ordinal(6)]  [RED("sceneTier")] public CEnum<GameplayTier> SceneTier { get; set; }
		[Ordinal(7)]  [RED("staminaController")] public wCHandle<NameplateBarLogicController> StaminaController { get; set; }
		[Ordinal(8)]  [RED("staminaControllerRef")] public inkWidgetReference StaminaControllerRef { get; set; }
		[Ordinal(9)]  [RED("staminaPercTextPath")] public inkTextWidgetReference StaminaPercTextPath { get; set; }
		[Ordinal(10)]  [RED("staminaPoolListener")] public CHandle<StaminaPoolListener> StaminaPoolListener { get; set; }
		[Ordinal(11)]  [RED("staminaState")] public CEnum<gamePSMStamina> StaminaState { get; set; }
		[Ordinal(12)]  [RED("staminaStatusTextPath")] public inkTextWidgetReference StaminaStatusTextPath { get; set; }

		public StaminabarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
