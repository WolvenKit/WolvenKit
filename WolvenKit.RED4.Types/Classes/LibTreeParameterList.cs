using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeParameterList : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parameters")] 
		public CArray<LibTreeParameter> Parameters
		{
			get => GetPropertyValue<CArray<LibTreeParameter>>();
			set => SetPropertyValue<CArray<LibTreeParameter>>(value);
		}

		public LibTreeParameterList()
		{
			Parameters = new();
		}
	}
}
