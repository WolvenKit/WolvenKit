using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SharedGameplayPS : gameDeviceComponentPS
	{
		[Ordinal(12)] [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(13)] [RED("authorizationProperties")] public AuthorizationData AuthorizationProperties { get; set; }
		[Ordinal(14)] [RED("wasStateCached")] public CBool WasStateCached { get; set; }
		[Ordinal(15)] [RED("wasStateSet")] public CBool WasStateSet { get; set; }
		[Ordinal(16)] [RED("cachedDeviceState")] public CEnum<EDeviceStatus> CachedDeviceState { get; set; }
		[Ordinal(17)] [RED("revealDevicesGrid")] public CBool RevealDevicesGrid { get; set; }
		[Ordinal(18)] [RED("revealDevicesGridWhenUnpowered")] public CBool RevealDevicesGridWhenUnpowered { get; set; }
		[Ordinal(19)] [RED("wasRevealedInNetworkPing")] public CBool WasRevealedInNetworkPing { get; set; }
		[Ordinal(20)] [RED("hasNetworkBackdoor")] public CBool HasNetworkBackdoor { get; set; }

		public SharedGameplayPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
