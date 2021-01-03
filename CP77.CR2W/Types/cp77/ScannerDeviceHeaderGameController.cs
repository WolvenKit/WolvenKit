using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerDeviceHeaderGameController : BaseChunkGameController
	{
		[Ordinal(0)]  [RED("attitudeCallbackID")] public CUInt32 AttitudeCallbackID { get; set; }
		[Ordinal(1)]  [RED("deviceStatusCallbackID")] public CUInt32 DeviceStatusCallbackID { get; set; }
		[Ordinal(2)]  [RED("fluffText")] public inkTextWidgetReference FluffText { get; set; }
		[Ordinal(3)]  [RED("isValidDeviceStatus")] public CBool IsValidDeviceStatus { get; set; }
		[Ordinal(4)]  [RED("isValidName")] public CBool IsValidName { get; set; }
		[Ordinal(5)]  [RED("isValidNetworkLevel")] public CBool IsValidNetworkLevel { get; set; }
		[Ordinal(6)]  [RED("isValidnetworkStatus")] public CBool IsValidnetworkStatus { get; set; }
		[Ordinal(7)]  [RED("levelText")] public inkTextWidgetReference LevelText { get; set; }
		[Ordinal(8)]  [RED("levelWrapper")] public inkWidgetReference LevelWrapper { get; set; }
		[Ordinal(9)]  [RED("nameCallbackID")] public CUInt32 NameCallbackID { get; set; }
		[Ordinal(10)]  [RED("nameText")] public inkTextWidgetReference NameText { get; set; }
		[Ordinal(11)]  [RED("networkLevelCallbackID")] public CUInt32 NetworkLevelCallbackID { get; set; }
		[Ordinal(12)]  [RED("networkStatusCallbackID")] public CUInt32 NetworkStatusCallbackID { get; set; }
		[Ordinal(13)]  [RED("separator1")] public inkRectangleWidgetReference Separator1 { get; set; }
		[Ordinal(14)]  [RED("separator2")] public inkRectangleWidgetReference Separator2 { get; set; }
		[Ordinal(15)]  [RED("status")] public inkTextWidgetReference Status { get; set; }
		[Ordinal(16)]  [RED("statusIcon")] public inkImageWidgetReference StatusIcon { get; set; }

		public ScannerDeviceHeaderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
