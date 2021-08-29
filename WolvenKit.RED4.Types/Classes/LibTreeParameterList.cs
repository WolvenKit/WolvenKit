using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeParameterList : RedBaseClass
	{
		private CArray<LibTreeParameter> _parameters;

		[Ordinal(0)] 
		[RED("parameters")] 
		public CArray<LibTreeParameter> Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}
	}
}
