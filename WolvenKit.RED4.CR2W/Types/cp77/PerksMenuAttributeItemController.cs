using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("attributeDisplay")] public inkWidgetReference AttributeDisplay { get; set; }
		[Ordinal(2)] [RED("connectionLine")] public inkImageWidgetReference ConnectionLine { get; set; }
		[Ordinal(3)] [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }
		[Ordinal(4)] [RED("skillsLevelsContainer")] public inkCompoundWidgetReference SkillsLevelsContainer { get; set; }
		[Ordinal(5)] [RED("proficiencyButtonRefs")] public CArray<inkWidgetReference> ProficiencyButtonRefs { get; set; }
		[Ordinal(6)] [RED("isReversed")] public CBool IsReversed { get; set; }
		[Ordinal(7)] [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(8)] [RED("attributeDisplayController")] public CHandle<PerksMenuAttributeDisplayController> AttributeDisplayController { get; set; }
		[Ordinal(9)] [RED("recentlyPurchased")] public CBool RecentlyPurchased { get; set; }
		[Ordinal(10)] [RED("holdStarted")] public CBool HoldStarted { get; set; }
		[Ordinal(11)] [RED("data")] public CHandle<AttributeData> Data { get; set; }
		[Ordinal(12)] [RED("cool_in_proxy")] public CHandle<inkanimProxy> Cool_in_proxy { get; set; }
		[Ordinal(13)] [RED("cool_out_proxy")] public CHandle<inkanimProxy> Cool_out_proxy { get; set; }

		public PerksMenuAttributeItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
