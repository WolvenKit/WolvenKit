using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberdeckDeviceQuickhackData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("UIIcon")] 
		public CWeakHandle<gamedataUIIcon_Record> UIIcon
		{
			get => GetPropertyValue<CWeakHandle<gamedataUIIcon_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataUIIcon_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("ObjectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		public CyberdeckDeviceQuickhackData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
