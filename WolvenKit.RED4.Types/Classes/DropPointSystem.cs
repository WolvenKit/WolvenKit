using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointSystem : gameScriptableSystem
	{
		private CArray<CHandle<DropPointPackage>> _packages;
		private CArray<CHandle<DropPointMappinRegistrationData>> _mappins;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("packages")] 
		public CArray<CHandle<DropPointPackage>> Packages
		{
			get => GetProperty(ref _packages);
			set => SetProperty(ref _packages, value);
		}

		[Ordinal(1)] 
		[RED("mappins")] 
		public CArray<CHandle<DropPointMappinRegistrationData>> Mappins
		{
			get => GetProperty(ref _mappins);
			set => SetProperty(ref _mappins, value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
