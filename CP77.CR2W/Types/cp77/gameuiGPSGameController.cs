using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiGPSGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("gpsSettings")] public gamegpsSettings GpsSettings { get; set; }

		public gameuiGPSGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
