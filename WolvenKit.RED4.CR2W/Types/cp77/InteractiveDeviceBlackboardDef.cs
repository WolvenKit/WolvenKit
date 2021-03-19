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
			get => GetProperty(ref _showAd);
			set => SetProperty(ref _showAd, value);
		}

		[Ordinal(8)] 
		[RED("showVendor")] 
		public gamebbScriptID_Bool ShowVendor
		{
			get => GetProperty(ref _showVendor);
			set => SetProperty(ref _showVendor, value);
		}

		public InteractiveDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
