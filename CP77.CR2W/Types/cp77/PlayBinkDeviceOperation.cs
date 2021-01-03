using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayBinkDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("bink")] public SBinkperationData Bink { get; set; }

		public PlayBinkDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
