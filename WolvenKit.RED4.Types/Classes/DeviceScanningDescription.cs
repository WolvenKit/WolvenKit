using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceScanningDescription : ObjectScanningDescription
	{
		private TweakDBID _deviceGameplayDescription;
		private CArray<TweakDBID> _deviceCustomDescriptions;
		private TweakDBID _deviceGameplayRole;
		private CArray<TweakDBID> _deviceRoleActionsDescriptions;

		[Ordinal(0)] 
		[RED("DeviceGameplayDescription")] 
		public TweakDBID DeviceGameplayDescription
		{
			get => GetProperty(ref _deviceGameplayDescription);
			set => SetProperty(ref _deviceGameplayDescription, value);
		}

		[Ordinal(1)] 
		[RED("DeviceCustomDescriptions")] 
		public CArray<TweakDBID> DeviceCustomDescriptions
		{
			get => GetProperty(ref _deviceCustomDescriptions);
			set => SetProperty(ref _deviceCustomDescriptions, value);
		}

		[Ordinal(2)] 
		[RED("DeviceGameplayRole")] 
		public TweakDBID DeviceGameplayRole
		{
			get => GetProperty(ref _deviceGameplayRole);
			set => SetProperty(ref _deviceGameplayRole, value);
		}

		[Ordinal(3)] 
		[RED("DeviceRoleActionsDescriptions")] 
		public CArray<TweakDBID> DeviceRoleActionsDescriptions
		{
			get => GetProperty(ref _deviceRoleActionsDescriptions);
			set => SetProperty(ref _deviceRoleActionsDescriptions, value);
		}
	}
}
