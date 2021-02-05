using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleDeviceLinkPS : DeviceLinkComponentPS
	{
		[Ordinal(0)]  [RED("markAsQuest")] public CBool MarkAsQuest { get; set; }
		[Ordinal(1)]  [RED("autoToggleQuestMark")] public CBool AutoToggleQuestMark { get; set; }
		[Ordinal(2)]  [RED("factToDisableQuestMark")] public CName FactToDisableQuestMark { get; set; }
		[Ordinal(3)]  [RED("callbackToDisableQuestMarkID")] public CUInt32 CallbackToDisableQuestMarkID { get; set; }
		[Ordinal(4)]  [RED("backdoorObjectiveData")] public CHandle<BackDoorObjectiveData> BackdoorObjectiveData { get; set; }
		[Ordinal(5)]  [RED("controlPanelObjectiveData")] public CHandle<ControlPanelObjectiveData> ControlPanelObjectiveData { get; set; }
		[Ordinal(6)]  [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(7)]  [RED("isScanned")] public CBool IsScanned { get; set; }
		[Ordinal(8)]  [RED("isBeingScanned")] public CBool IsBeingScanned { get; set; }
		[Ordinal(9)]  [RED("exposeQuickHacks")] public CBool ExposeQuickHacks { get; set; }
		[Ordinal(10)]  [RED("isAttachedToGame")] public CBool IsAttachedToGame { get; set; }
		[Ordinal(11)]  [RED("isLogicReady")] public CBool IsLogicReady { get; set; }
		[Ordinal(12)]  [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(13)]  [RED("authorizationProperties")] public AuthorizationData AuthorizationProperties { get; set; }
		[Ordinal(14)]  [RED("wasStateCached")] public CBool WasStateCached { get; set; }
		[Ordinal(15)]  [RED("wasStateSet")] public CBool WasStateSet { get; set; }
		[Ordinal(16)]  [RED("cachedDeviceState")] public CEnum<EDeviceStatus> CachedDeviceState { get; set; }
		[Ordinal(17)]  [RED("revealDevicesGrid")] public CBool RevealDevicesGrid { get; set; }
		[Ordinal(18)]  [RED("revealDevicesGridWhenUnpowered")] public CBool RevealDevicesGridWhenUnpowered { get; set; }
		[Ordinal(19)]  [RED("wasRevealedInNetworkPing")] public CBool WasRevealedInNetworkPing { get; set; }
		[Ordinal(20)]  [RED("hasNetworkBackdoor")] public CBool HasNetworkBackdoor { get; set; }
		[Ordinal(21)]  [RED("parentDevice")] public DeviceLink ParentDevice { get; set; }
		[Ordinal(22)]  [RED("isConnected")] public CBool IsConnected { get; set; }
		[Ordinal(23)]  [RED("ownerEntityID")] public entEntityID OwnerEntityID { get; set; }

		public VehicleDeviceLinkPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
