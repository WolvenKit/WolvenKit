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
			get
			{
				if (_gpsSettings == null)
				{
					_gpsSettings = (gamegpsSettings) CR2WTypeManager.Create("gamegpsSettings", "gpsSettings", cr2w, this);
				}
				return _gpsSettings;
			}
			set
			{
				if (_gpsSettings == value)
				{
					return;
				}
				_gpsSettings = value;
				PropertySet(this);
			}
		}

		public gameuiGPSGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
