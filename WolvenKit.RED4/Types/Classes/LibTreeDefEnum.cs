using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefEnum : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("variableId")] 
		public CUInt16 VariableId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("treeVariable")] 
		public CName TreeVariable
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("v")] 
		public CInt64 V
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		public LibTreeDefEnum()
		{
			VariableId = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
