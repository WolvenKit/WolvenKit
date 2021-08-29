using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMaterialOverride : RedBaseClass
	{
		private CName _base;
		private CName _override;

		[Ordinal(0)] 
		[RED("base")] 
		public CName Base
		{
			get => GetProperty(ref _base);
			set => SetProperty(ref _base, value);
		}

		[Ordinal(1)] 
		[RED("override")] 
		public CName Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}
	}
}
