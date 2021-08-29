using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGodModeEntityData : RedBaseClass
	{
		private CArray<gameGodModeData> _overrides;
		private CArray<gameGodModeData> _base;

		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<gameGodModeData> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		[Ordinal(1)] 
		[RED("base")] 
		public CArray<gameGodModeData> Base
		{
			get => GetProperty(ref _base);
			set => SetProperty(ref _base, value);
		}
	}
}
