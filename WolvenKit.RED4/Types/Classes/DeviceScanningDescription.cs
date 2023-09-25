using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceScanningDescription : ObjectScanningDescription
	{
		[Ordinal(0)] 
		[RED("DeviceGameplayDescription")] 
		public TweakDBID DeviceGameplayDescription
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("DeviceCustomDescriptions")] 
		public CArray<TweakDBID> DeviceCustomDescriptions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(2)] 
		[RED("DeviceGameplayRole")] 
		public TweakDBID DeviceGameplayRole
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("DeviceRoleActionsDescriptions")] 
		public CArray<TweakDBID> DeviceRoleActionsDescriptions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public DeviceScanningDescription()
		{
			DeviceCustomDescriptions = new();
			DeviceRoleActionsDescriptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
