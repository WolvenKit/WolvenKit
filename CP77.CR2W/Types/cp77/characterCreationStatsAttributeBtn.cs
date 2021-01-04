using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class characterCreationStatsAttributeBtn : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("addBtn")] public inkWidgetReference AddBtn { get; set; }
		[Ordinal(1)]  [RED("addBtnNONE")] public inkWidgetReference AddBtnNONE { get; set; }
		[Ordinal(2)]  [RED("addBtnState")] public CEnum<AttributeButtonState> AddBtnState { get; set; }
		[Ordinal(3)]  [RED("addBtnhitArea")] public inkWidgetReference AddBtnhitArea { get; set; }
		[Ordinal(4)]  [RED("addEnabled")] public CBool AddEnabled { get; set; }
		[Ordinal(5)]  [RED("animating")] public CBool Animating { get; set; }
		[Ordinal(6)]  [RED("data")] public CHandle<CharacterCreationAttributeData> Data { get; set; }
		[Ordinal(7)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(8)]  [RED("maxed")] public CBool Maxed { get; set; }
		[Ordinal(9)]  [RED("minMaxLabel")] public inkWidgetReference MinMaxLabel { get; set; }
		[Ordinal(10)]  [RED("minMaxLabelText")] public inkTextWidgetReference MinMaxLabelText { get; set; }
		[Ordinal(11)]  [RED("minusBtn")] public inkWidgetReference MinusBtn { get; set; }
		[Ordinal(12)]  [RED("minusBtnNONE")] public inkWidgetReference MinusBtnNONE { get; set; }
		[Ordinal(13)]  [RED("minusBtnState")] public CEnum<AttributeButtonState> MinusBtnState { get; set; }
		[Ordinal(14)]  [RED("minusBtnhitArea")] public inkWidgetReference MinusBtnhitArea { get; set; }
		[Ordinal(15)]  [RED("minusEnabled")] public CBool MinusEnabled { get; set; }
		[Ordinal(16)]  [RED("state")] public CEnum<AttributeButtonState> State { get; set; }
		[Ordinal(17)]  [RED("value")] public inkTextWidgetReference Value { get; set; }

		public characterCreationStatsAttributeBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
