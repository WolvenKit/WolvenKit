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

		[Ordinal(2)] 
		[RED("ObjectActionName")] 
		public CName ObjectActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("ObjectActionLocName")] 
		public CName ObjectActionLocName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("ObjectActionTier")] 
		public CEnum<gamedataDeviceHackTier> ObjectActionTier
		{
			get => GetPropertyValue<CEnum<gamedataDeviceHackTier>>();
			set => SetPropertyValue<CEnum<gamedataDeviceHackTier>>(value);
		}

		[Ordinal(5)] 
		[RED("ObjectActionCategory")] 
		public CEnum<gamedataDeviceHackCategory> ObjectActionCategory
		{
			get => GetPropertyValue<CEnum<gamedataDeviceHackCategory>>();
			set => SetPropertyValue<CEnum<gamedataDeviceHackCategory>>(value);
		}

		[Ordinal(6)] 
		[RED("ObjectActionType")] 
		public CEnum<gamedataObjectActionType> ObjectActionType
		{
			get => GetPropertyValue<CEnum<gamedataObjectActionType>>();
			set => SetPropertyValue<CEnum<gamedataObjectActionType>>(value);
		}

		[Ordinal(7)] 
		[RED("Priority")] 
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CyberdeckDeviceQuickhackData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
