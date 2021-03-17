using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckDeviceQuickhackData : CVariable
	{
		private wCHandle<gamedataUIIcon_Record> _uIIcon;
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;

		[Ordinal(0)] 
		[RED("UIIcon")] 
		public wCHandle<gamedataUIIcon_Record> UIIcon
		{
			get => GetProperty(ref _uIIcon);
			set => SetProperty(ref _uIIcon, value);
		}

		[Ordinal(1)] 
		[RED("ObjectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		public CyberdeckDeviceQuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
