using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionCustomData : SDeviceActionData
	{
		[Ordinal(10)] [RED("actionID")] public CName ActionID { get; set; }
		[Ordinal(11)] [RED("On")] public CBool On { get; set; }
		[Ordinal(12)] [RED("Off")] public CBool Off { get; set; }
		[Ordinal(13)] [RED("Unpowered")] public CBool Unpowered { get; set; }
		[Ordinal(14)] [RED("displayNameRecord")] public TweakDBID DisplayNameRecord { get; set; }
		[Ordinal(15)] [RED("displayName")] public CString DisplayName { get; set; }
		[Ordinal(16)] [RED("customClearance")] public CInt32 CustomClearance { get; set; }
		[Ordinal(17)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(18)] [RED("disableOnUse")] public CBool DisableOnUse { get; set; }
		[Ordinal(19)] [RED("factToEnableName")] public CName FactToEnableName { get; set; }
		[Ordinal(20)] [RED("quickHackCost")] public CInt32 QuickHackCost { get; set; }
		[Ordinal(21)] [RED("callbackID")] public CUInt32 CallbackID { get; set; }

		public SDeviceActionCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
