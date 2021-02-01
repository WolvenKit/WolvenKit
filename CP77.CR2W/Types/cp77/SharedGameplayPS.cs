using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SharedGameplayPS : gameDeviceComponentPS
	{
		[Ordinal(0)]  [RED("authorizationProperties")] public AuthorizationData AuthorizationProperties { get; set; }
		[Ordinal(1)]  [RED("cachedDeviceState")] public CEnum<EDeviceStatus> CachedDeviceState { get; set; }
		[Ordinal(2)]  [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(3)]  [RED("hasNetworkBackdoor")] public CBool HasNetworkBackdoor { get; set; }
		[Ordinal(4)]  [RED("revealDevicesGrid")] public CBool RevealDevicesGrid { get; set; }
		[Ordinal(5)]  [RED("revealDevicesGridWhenUnpowered")] public CBool RevealDevicesGridWhenUnpowered { get; set; }
		[Ordinal(6)]  [RED("wasRevealedInNetworkPing")] public CBool WasRevealedInNetworkPing { get; set; }
		[Ordinal(7)]  [RED("wasStateCached")] public CBool WasStateCached { get; set; }
		[Ordinal(8)]  [RED("wasStateSet")] public CBool WasStateSet { get; set; }

		public SharedGameplayPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
