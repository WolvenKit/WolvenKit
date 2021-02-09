using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributes_ContainersStruct : CVariable
	{
		[Ordinal(0)]  [RED("widgetBody")] public inkWidgetReference WidgetBody { get; set; }
		[Ordinal(1)]  [RED("widgetCool")] public inkWidgetReference WidgetCool { get; set; }
		[Ordinal(2)]  [RED("widgetInt")] public inkWidgetReference WidgetInt { get; set; }
		[Ordinal(3)]  [RED("widgetRef")] public inkWidgetReference WidgetRef { get; set; }
		[Ordinal(4)]  [RED("widgetTech")] public inkWidgetReference WidgetTech { get; set; }
		[Ordinal(5)]  [RED("logicBody")] public CHandle<CyberwareAttributes_Logic> LogicBody { get; set; }
		[Ordinal(6)]  [RED("logicCool")] public CHandle<CyberwareAttributes_Logic> LogicCool { get; set; }
		[Ordinal(7)]  [RED("logicInt")] public CHandle<CyberwareAttributes_Logic> LogicInt { get; set; }
		[Ordinal(8)]  [RED("logicRef")] public CHandle<CyberwareAttributes_Logic> LogicRef { get; set; }
		[Ordinal(9)]  [RED("logicTech")] public CHandle<CyberwareAttributes_Logic> LogicTech { get; set; }

		public CyberwareAttributes_ContainersStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
