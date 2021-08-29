using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentWoundsConfigSet : RedBaseClass
	{
		private CArray<CHandle<entdismembermentWoundConfigContainer>> _configs;

		[Ordinal(0)] 
		[RED("Configs")] 
		public CArray<CHandle<entdismembermentWoundConfigContainer>> Configs
		{
			get => GetProperty(ref _configs);
			set => SetProperty(ref _configs, value);
		}
	}
}
