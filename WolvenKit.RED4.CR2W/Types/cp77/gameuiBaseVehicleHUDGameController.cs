using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseVehicleHUDGameController : gameuiHUDGameController
	{
		private CBool _mounted;

		[Ordinal(9)] 
		[RED("mounted")] 
		public CBool Mounted
		{
			get
			{
				if (_mounted == null)
				{
					_mounted = (CBool) CR2WTypeManager.Create("Bool", "mounted", cr2w, this);
				}
				return _mounted;
			}
			set
			{
				if (_mounted == value)
				{
					return;
				}
				_mounted = value;
				PropertySet(this);
			}
		}

		public gameuiBaseVehicleHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
