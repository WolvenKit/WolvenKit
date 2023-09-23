using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceLinkComponentPS : SharedGameplayPS
	{
		[Ordinal(23)] 
		[RED("parentDevice")] 
		public DeviceLink ParentDevice
		{
			get => GetPropertyValue<DeviceLink>();
			set => SetPropertyValue<DeviceLink>(value);
		}

		[Ordinal(24)] 
		[RED("isConnected")] 
		public CBool IsConnected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public DeviceLinkComponentPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
