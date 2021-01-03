using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NetRunnerChargesGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(1)]  [RED("bbDefinition")] public CHandle<UI_PlayerBioMonitorDef> BbDefinition { get; set; }
		[Ordinal(2)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(3)]  [RED("chargesList")] public CArray<CHandle<NetRunnerListItem>> ChargesList { get; set; }
		[Ordinal(4)]  [RED("currentCharges")] public CInt32 CurrentCharges { get; set; }
		[Ordinal(5)]  [RED("header")] public inkTextWidgetReference Header { get; set; }
		[Ordinal(6)]  [RED("list")] public inkCompoundWidgetReference List { get; set; }
		[Ordinal(7)]  [RED("maxCharges")] public CInt32 MaxCharges { get; set; }
		[Ordinal(8)]  [RED("netrunnerCapacityId")] public CUInt32 NetrunnerCapacityId { get; set; }
		[Ordinal(9)]  [RED("netrunnerCurrentId")] public CUInt32 NetrunnerCurrentId { get; set; }
		[Ordinal(10)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(11)]  [RED("value")] public inkTextWidgetReference Value { get; set; }

		public NetRunnerChargesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
