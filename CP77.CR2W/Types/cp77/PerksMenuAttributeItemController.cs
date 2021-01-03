using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("attributeDisplay")] public inkWidgetReference AttributeDisplay { get; set; }
		[Ordinal(1)]  [RED("attributeDisplayController")] public CHandle<PerksMenuAttributeDisplayController> AttributeDisplayController { get; set; }
		[Ordinal(2)]  [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }
		[Ordinal(3)]  [RED("connectionLine")] public inkImageWidgetReference ConnectionLine { get; set; }
		[Ordinal(4)]  [RED("cool_in_proxy")] public CHandle<inkanimProxy> Cool_in_proxy { get; set; }
		[Ordinal(5)]  [RED("cool_out_proxy")] public CHandle<inkanimProxy> Cool_out_proxy { get; set; }
		[Ordinal(6)]  [RED("data")] public CHandle<AttributeData> Data { get; set; }
		[Ordinal(7)]  [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(8)]  [RED("holdStarted")] public CBool HoldStarted { get; set; }
		[Ordinal(9)]  [RED("isReversed")] public CBool IsReversed { get; set; }
		[Ordinal(10)]  [RED("proficiencyButtonRefs")] public CArray<inkWidgetReference> ProficiencyButtonRefs { get; set; }
		[Ordinal(11)]  [RED("recentlyPurchased")] public CBool RecentlyPurchased { get; set; }
		[Ordinal(12)]  [RED("skillsLevelsContainer")] public inkCompoundWidgetReference SkillsLevelsContainer { get; set; }

		public PerksMenuAttributeItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
