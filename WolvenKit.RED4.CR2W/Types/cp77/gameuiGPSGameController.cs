using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGPSGameController : gameuiHUDGameController
	{
		private gamegpsSettings _gpsSettings;

		[Ordinal(9)] 
		[RED("gpsSettings")] 
		public gamegpsSettings GpsSettings
		{
			get => GetProperty(ref _gpsSettings);
			set => SetProperty(ref _gpsSettings, value);
		}

		public gameuiGPSGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
