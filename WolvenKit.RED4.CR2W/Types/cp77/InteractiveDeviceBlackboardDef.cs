using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Bool _showAd;
		private gamebbScriptID_Bool _showVendor;

		[Ordinal(7)] 
		[RED("showAd")] 
		public gamebbScriptID_Bool ShowAd
		{
			get
			{
				if (_showAd == null)
				{
					_showAd = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "showAd", cr2w, this);
				}
				return _showAd;
			}
			set
			{
				if (_showAd == value)
				{
					return;
				}
				_showAd = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("showVendor")] 
		public gamebbScriptID_Bool ShowVendor
		{
			get
			{
				if (_showVendor == null)
				{
					_showVendor = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "showVendor", cr2w, this);
				}
				return _showVendor;
			}
			set
			{
				if (_showVendor == value)
				{
					return;
				}
				_showVendor = value;
				PropertySet(this);
			}
		}

		public InteractiveDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
