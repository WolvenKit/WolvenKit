using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceLinkEstablished : redEvent
	{
		private wCHandle<DeviceLinkComponentPS> _deviceLinkPS;

		[Ordinal(0)] 
		[RED("deviceLinkPS")] 
		public wCHandle<DeviceLinkComponentPS> DeviceLinkPS
		{
			get => GetProperty(ref _deviceLinkPS);
			set => SetProperty(ref _deviceLinkPS, value);
		}

		public DeviceLinkEstablished(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
