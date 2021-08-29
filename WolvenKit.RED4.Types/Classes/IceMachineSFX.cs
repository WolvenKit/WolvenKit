using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IceMachineSFX : VendingMachineSFX
	{
		private CName _iceFalls;
		private CName _processing;

		[Ordinal(2)] 
		[RED("iceFalls")] 
		public CName IceFalls
		{
			get => GetProperty(ref _iceFalls);
			set => SetProperty(ref _iceFalls, value);
		}

		[Ordinal(3)] 
		[RED("processing")] 
		public CName Processing
		{
			get => GetProperty(ref _processing);
			set => SetProperty(ref _processing, value);
		}
	}
}
