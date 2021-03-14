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
			get
			{
				if (_thumbnailWidgetsData == null)
				{
					_thumbnailWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ThumbnailWidgetsData", cr2w, this);
				}
				return _thumbnailWidgetsData;
			}
			set
			{
				if (_thumbnailWidgetsData == value)
				{
					return;
				}
				_thumbnailWidgetsData = value;
				PropertySet(this);
			}
		}

		public MasterDeviceBaseBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
