using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponVendingMachineSFX : VendingMachineSFX
	{
		private CName _processing;
		private CName _gunFalls;

		[Ordinal(2)] 
		[RED("processing")] 
		public CName Processing
		{
			get => GetProperty(ref _processing);
			set => SetProperty(ref _processing, value);
		}

		[Ordinal(3)] 
		[RED("gunFalls")] 
		public CName GunFalls
		{
			get => GetProperty(ref _gunFalls);
			set => SetProperty(ref _gunFalls, value);
		}

		public WeaponVendingMachineSFX()
		{
			_processing = "dev_vending_machine_processing";
		}
	}
}
