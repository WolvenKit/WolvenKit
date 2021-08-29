using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberdeckDeviceQuickhackData : RedBaseClass
	{
		private CWeakHandle<gamedataUIIcon_Record> _uIIcon;
		private CWeakHandle<gamedataObjectAction_Record> _objectActionRecord;

		[Ordinal(0)] 
		[RED("UIIcon")] 
		public CWeakHandle<gamedataUIIcon_Record> UIIcon
		{
			get => GetProperty(ref _uIIcon);
			set => SetProperty(ref _uIIcon, value);
		}

		[Ordinal(1)] 
		[RED("ObjectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}
	}
}
