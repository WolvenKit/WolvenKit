using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MasterDeviceBaseBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _thumbnailWidgetsData;

		[Ordinal(7)] 
		[RED("ThumbnailWidgetsData")] 
		public gamebbScriptID_Variant ThumbnailWidgetsData
		{
			get => GetProperty(ref _thumbnailWidgetsData);
			set => SetProperty(ref _thumbnailWidgetsData, value);
		}

		public MasterDeviceBaseBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
