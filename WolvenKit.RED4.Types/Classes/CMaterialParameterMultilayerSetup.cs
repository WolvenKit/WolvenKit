using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterMultilayerSetup : CMaterialParameter
	{
		private CResourceReference<Multilayer_Setup> _setup;

		[Ordinal(2)] 
		[RED("setup")] 
		public CResourceReference<Multilayer_Setup> Setup
		{
			get => GetProperty(ref _setup);
			set => SetProperty(ref _setup, value);
		}
	}
}
