using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAnimSetDynAnimNames : RedBaseClass
	{
		private CStatic<CName> _animVariable;
		private CArray<CName> _animNames;

		[Ordinal(0)] 
		[RED("animVariable", 1)] 
		public CStatic<CName> AnimVariable
		{
			get => GetProperty(ref _animVariable);
			set => SetProperty(ref _animVariable, value);
		}

		[Ordinal(1)] 
		[RED("animNames")] 
		public CArray<CName> AnimNames
		{
			get => GetProperty(ref _animNames);
			set => SetProperty(ref _animNames, value);
		}
	}
}
