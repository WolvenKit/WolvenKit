using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformSavedData : CVariable
	{
		[Ordinal(0)]  [RED("destinationData")] public CInt32 DestinationData { get; set; }
		[Ordinal(1)]  [RED("destinationName")] public CName DestinationName { get; set; }
		[Ordinal(2)]  [RED("maxTime")] public CFloat MaxTime { get; set; }
		[Ordinal(3)]  [RED("mountedPlayerEntityID")] public CUInt32 MountedPlayerEntityID { get; set; }
		[Ordinal(4)]  [RED("movement")] public CHandle<gameIMovingPlatformMovement> Movement { get; set; }
		[Ordinal(5)]  [RED("time")] public CFloat Time { get; set; }

		public gameMovingPlatformSavedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
